namespace RtD.Data.Json {
    internal sealed class ItemQualitiesLoader : LoaderBase<ItemQualitiesLoader.JsonData> {
        #region Properties / Felder
        public List<ItemQualityData> Data { get; } = new List<ItemQualityData>();
        #endregion

        #region Konstruktor
        public ItemQualitiesLoader(Main aParent) : base(aParent) { }
        #endregion

        #region Methoden
        public Components.Notification[] LoadData(string aPathName) {
            base.LoadData(aPathName, "ItemQualities.json");

            if (base.Json == null) {
                throw new Exceptions.MissingDataException();
            } else {
                IEnumerable<ItemQualitiesJsonData> lData = RemoveEmpty(base.Json.Data);
                uint lSortOrder = 0;

                base.Check4Dublicates(lData);

                if (lData.Where(x => x.Downgrade == null).Count() != 1) { // Es darf nur 1 Downgrade NULL sein.
                                                                          // TODO: Exception
                }

                if (lData.Where(x => x.Upgrade == null).Count() != 1) { // Es darf nur 1 Upgrade NULL sein.
                                                                        // TODO: Exception
                }

                if (lData.GroupBy(x => x.Downgrade)
                    .Where(g => g.Skip(1).Any())
                    .SelectMany(x => x)
                    .Any()) {
                    // TODO: Exception
                }

                if (lData.GroupBy(x => x.Upgrade)
                   .Where(g => g.Skip(1).Any())
                   .SelectMany(x => x)
                   .Any()) {
                    // TODO: Exception
                }

                foreach (ItemQualitiesJsonData lJsonData in lData
                    .Where(x => x.Downgrade == null)
                    .Concat(lData
                        .Where(x => x.Downgrade != null)
                        .OrderBy(x => x.Downgrade))) {
                    Data.Add(new ItemQualityData(lJsonData, lSortOrder++));
                }

                foreach (ItemQualitiesJsonData lJsonData in lData) {
                    ItemQualityData lItem = Data.Where(x => x.ID == lJsonData.ID).First();

                    if (lJsonData.Downgrade != null) {
                        lItem.Downgrade = Data.Where(x => x.ID == lJsonData.Downgrade).First();
                    }
                    if (lJsonData.Upgrade != null) {
                        lItem.Upgrade = Data.Where(x => x.ID == lJsonData.Upgrade).First();
                    }
                }
            }
        
            return base.GetNotifications();
        }

        private IEnumerable<ItemQualitiesJsonData> RemoveEmpty(IEnumerable<ItemQualitiesJsonData> aData) {
            aData = base.RemoveEmpty(aData);

            if (aData.Where(x => x.Effect == null).Any()) {
                // TODO: Warning
                base.AddWarning(0);
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