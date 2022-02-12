namespace RtD.Data.Json {
    internal sealed class ItemsLoader : LoaderBase<ItemJsonData> {
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

            foreach (ItemJsonData lJsonData in base.JsonData
                .OrderBy(x => x.ItemTypeEnum_ID)
                .ThenBy(x => x.Name)) {
                lResult.Add(new ItemData(lJsonData));
            }

            // Patrik: Sprache laden

            return lResult;
        }
        #endregion
    }
}