﻿namespace RtD.Data.Json { // Json/Loader
    internal sealed class ItemQualitiesLoader : LoaderBase<ItemQuality.ItemQualityJsonData> {
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
                throw new Exceptions.DublicateDataException(nameof(ItemQuality.ItemQualityJsonData.Downgrade));
            }

            if (base.JsonData.Where(x => x.Upgrade == null).Count() != 1) { // Es darf nur 1 Upgrade NULL sein.
                throw new Exceptions.DublicateDataException(nameof(ItemQuality.ItemQualityJsonData.Upgrade));
            }

            if (base.JsonData.GroupBy(x => x.Downgrade)
                .Where(g => g.Skip(1).Any())
                .SelectMany(x => x)
                .Any()) { // Doppelte Downgrade's
                throw new Exceptions.DublicateDataException(nameof(ItemQuality.ItemQualityJsonData.Downgrade));
            }

            if (base.JsonData.GroupBy(x => x.Upgrade)
                .Where(g => g.Skip(1).Any())
                .SelectMany(x => x)
                .Any()) { // Doppelte Upgrade's
                throw new Exceptions.DublicateDataException(nameof(ItemQuality.ItemQualityJsonData.Upgrade));
            }

            foreach (ItemQuality.ItemQualityJsonData lJsonData in base.JsonData
                .Where(x => x.Downgrade == null)
                .Concat(base.JsonData
                    .Where(x => x.Downgrade != null)
                    .OrderBy(x => x.Downgrade))) {
                lResult.Add(new ItemQualityData(lJsonData, lSortOrder++));
            }

            foreach (ItemQuality.ItemQualityJsonData lJsonData in base.JsonData) {
                ItemQualityData lItem = lResult.Where(x => x.ID == lJsonData.ID).First();

                if (lJsonData.Downgrade != null) {
                    lItem.Downgrade = lResult.Where(x => x.ID == lJsonData.Downgrade).First();
                }
                if (lJsonData.Upgrade != null) {
                    lItem.Upgrade = lResult.Where(x => x.ID == lJsonData.Upgrade).First();
                }
            }

            return lResult;
        }

        private new void RemoveEmpty() {
            base.RemoveEmpty();

            if (base.Except(base.JsonData.Where(x => x.Effect == null))) {
                Main.AddWarning(0000, nameof(ItemQuality.ItemQualityJsonData.Effect));
            }
        }
        #endregion
    }
}