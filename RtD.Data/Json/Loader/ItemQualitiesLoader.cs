namespace RtD.Data.Json {
    internal sealed class ItemQualitiesLoader : LoaderBase<ItemQualitiesLoader.JsonData> {
        #region Konstruktor
        public ItemQualitiesLoader(Main aParent, Enumerations.LanguageEnum aLanguage)
            : base(aParent, aLanguage) { }
        #endregion

        #region Methoden
        public List<ItemQualityData> LoadData(string aPathName) {
            List<ItemQualityData> lResult = new();
            
            base.LoadData(aPathName, Constants.GetJsonFileName(1));

            if (base.Json == null) {
                throw new Exceptions.MissingDataException();
            } else {
                IEnumerable<ItemQualitiesJsonData> lData = RemoveEmpty(base.Json.Data);
                uint lSortOrder = 0;

                base.Check4Dublicates(lData);

                if (lData.Where(x => x.Downgrade == null).Count() != 1) { // Es darf nur 1 Downgrade NULL sein.
                    throw new Exceptions.DublicateDataException(nameof(ItemQualitiesJsonData.Downgrade));
                }

                if (lData.Where(x => x.Upgrade == null).Count() != 1) { // Es darf nur 1 Upgrade NULL sein.
                    throw new Exceptions.DublicateDataException(nameof(ItemQualitiesJsonData.Upgrade));
                }

                if (lData.GroupBy(x => x.Downgrade)
                    .Where(g => g.Skip(1).Any())
                    .SelectMany(x => x)
                    .Any()) {
                    throw new Exceptions.DublicateDataException(nameof(ItemQualitiesJsonData.Downgrade));
                }

                if (lData.GroupBy(x => x.Upgrade)
                   .Where(g => g.Skip(1).Any())
                   .SelectMany(x => x)
                   .Any()) {
                    throw new Exceptions.DublicateDataException(nameof(ItemQualitiesJsonData.Upgrade));
                }

                foreach (ItemQualitiesJsonData lJsonData in lData
                    .Where(x => x.Downgrade == null)
                    .Concat(lData
                        .Where(x => x.Downgrade != null)
                        .OrderBy(x => x.Downgrade))) {
                    lResult.Add(new ItemQualityData(lJsonData, lSortOrder++));
                }

                foreach (ItemQualitiesJsonData lJsonData in lData) {
                    ItemQualityData lItem = lResult.Where(x => x.ID == lJsonData.ID).First();

                    if (lJsonData.Downgrade != null) {
                        lItem.Downgrade = lResult.Where(x => x.ID == lJsonData.Downgrade).First();
                    }
                    if (lJsonData.Upgrade != null) {
                        lItem.Upgrade = lResult.Where(x => x.ID == lJsonData.Upgrade).First();
                    }
                }
            }

            // TODO: Sprache laden

            return lResult;
        }

        private IEnumerable<ItemQualitiesJsonData> RemoveEmpty(IEnumerable<ItemQualitiesJsonData> aData) {
            aData = base.RemoveEmpty(aData);

            if (aData.Where(x => x.Effect == null).Any()) {
                Main.AddWarning(0000, nameof(ItemQualitiesJsonData.Effect));
            }

            return aData.Where(x => x.Effect != null);
        }

        #endregion

        #region Verschachtete Klassen
        public class JsonData {
            public List<ItemQualitiesJsonData> Data { get; } = new();
        }
        #endregion
    }
}