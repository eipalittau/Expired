namespace RtD.Data.Json {
    internal sealed class ItemsLoader : LoaderBase<ItemsLoader.JsonData> {
        #region Properties / Felder
        public List<ItemData> Data { get; } = new List<ItemData>();
        #endregion

        #region Konstruktor
        public ItemsLoader(Main aParent) : base(aParent) { }
        #endregion

        #region Methoden
        public Components.Notification[] LoadData(string aPathName) {
            base.LoadData(aPathName, "Items.json");

            if (base.Json == null) {
                throw new Exceptions.MissingDataException();
            } else {
                IEnumerable<ItemJsonData> lData = base.RemoveEmpty(base.Json.Data);
                base.Check4Dublicates(lData);

                foreach (ItemJsonData lJsonData in lData
                    .OrderBy(x => x.ItemTypeEnum_ID)
                    .ThenBy(x => x.Name)) {
                    Data.Add(new ItemData(lJsonData));
                }
            }
            
            return base.GetNotifications();
        }
        #endregion

        #region Verschachtete Klassen
        public class JsonData {
            public List<ItemJsonData> Data { get; } = new();
        }
        #endregion
    }
}