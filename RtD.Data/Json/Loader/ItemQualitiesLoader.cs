namespace RtD.Data.Json {
    internal sealed class ItemQualitiesLoader : LoaderBase<ItemQualityJsonData> {
        #region Konstruktor
        public ItemQualitiesLoader(Main aParent, Enumerations.LanguageEnum aLanguage)
            : base(aParent, aLanguage) { }
        #endregion

        #region Methoden
        public List<ItemQualityData> LoadData(string aPathName) {
            List<ItemQualityData> lResult = new();
             uint lSortOrder = 0;
           
            base.LoadData(aPathName, 1);
            RemoveEmpty();
            base.Check4Dublicates();

            if (base.JsonData.Where(x => x.Downgrade == null).Count() != 1) { // Es darf nur 1 Downgrade NULL sein.
                throw new Exceptions.DublicateDataException(nameof(ItemQualityJsonData.Downgrade));
            }

            if (base.JsonData.Where(x => x.Upgrade == null).Count() != 1) { // Es darf nur 1 Upgrade NULL sein.
                throw new Exceptions.DublicateDataException(nameof(ItemQualityJsonData.Upgrade));
            }

            if (base.JsonData.GroupBy(x => x.Downgrade)
                .Where(g => g.Skip(1).Any())
                .SelectMany(x => x)
                .Any()) {
                throw new Exceptions.DublicateDataException(nameof(ItemQualityJsonData.Downgrade));
            }

            if (base.JsonData.GroupBy(x => x.Upgrade)
                .Where(g => g.Skip(1).Any())
                .SelectMany(x => x)
                .Any()) {
                throw new Exceptions.DublicateDataException(nameof(ItemQualityJsonData.Upgrade));
            }

            foreach (ItemQualityJsonData lJsonData in base.JsonData
                .Where(x => x.Downgrade == null)
                .Concat(base.JsonData
                    .Where(x => x.Downgrade != null)
                    .OrderBy(x => x.Downgrade))) {
                lResult.Add(new ItemQualityData(lJsonData, lSortOrder++));
            }

            foreach (ItemQualityJsonData lJsonData in base.JsonData) {
                ItemQualityData lItem = lResult.Where(x => x.ID == lJsonData.ID).First();

                if (lJsonData.Downgrade != null) {
                    lItem.Downgrade = lResult.Where(x => x.ID == lJsonData.Downgrade).First();
                }
                if (lJsonData.Upgrade != null) {
                    lItem.Upgrade = lResult.Where(x => x.ID == lJsonData.Upgrade).First();
                }
            }

            // Patrik: Sprache laden

            return lResult;
        }

        private new void RemoveEmpty() {
            base.RemoveEmpty();

            IEnumerable<ItemQualityJsonData>? lNullEffect = base.JsonData
                .Where(x => x.Effect == null);

            if (base.Except(lNullEffect)) {
                Main.AddWarning(0000, nameof(ItemQualityJsonData.Effect));
            }
        }
        #endregion
    }
}