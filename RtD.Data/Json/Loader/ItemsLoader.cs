namespace RtD.Data.Json {
    internal sealed class ItemsLoader : LoaderBase<ItemsLoader.JsonData> {
        #region Konstruktor
        public ItemsLoader(Main aParent, Enumerations.LanguageEnum aLanguage)
            : base(aParent, aLanguage) { }
        #endregion

        #region Methoden
        public List<ItemData> LoadData(string aPathName) {
            List<ItemData> lResult = new();

            base.LoadData(aPathName, Constants.GetJsonFileName(2));

            if (base.Json == null) {
                throw new Exceptions.MissingDataException();
            } else {
                IEnumerable<ItemJsonData> lData = base.RemoveEmpty(base.Json.Data);

                base.Check4Dublicates(lData);

                foreach (ItemJsonData lJsonData in lData
                    .OrderBy(x => x.ItemTypeEnum_ID)
                    .ThenBy(x => x.Name)) {
                    lResult.Add(new ItemData(lJsonData));
                }
            }
            
            return lResult;
        }
        #endregion

        #region Verschachtete Klassen
        public class JsonData {
            public List<ItemJsonData> Data { get; } = new();
        }
        #endregion
    }
}