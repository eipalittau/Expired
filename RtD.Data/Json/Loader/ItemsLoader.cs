namespace RtD.Data.Json { // Json/Loader
    internal sealed class ItemsLoader : LoaderBase<Item.ItemJsonData> {
        #region Konstruktor
        public ItemsLoader(Main aParent, Enumerations.LanguageEnum aLanguage)
            : base(aParent, aLanguage) { }
        #endregion

        #region Methoden
        public List<ItemData> LoadData(string aPathName) {
            List<ItemData> lResult = new();

            base.LoadData(aPathName, 2);
            base.RemoveEmpty();
            base.Check4Dublicates();

            foreach (Item.ItemJsonData lJsonData in base.JsonData
                .OrderBy(x => x.ItemTypeEnum_ID)
                .ThenBy(x => x.Name)) {
                lResult.Add(new ItemData(lJsonData));
            }

            return lResult;
        }
        #endregion
    }
}