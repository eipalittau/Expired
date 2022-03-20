namespace RtD.Data.Json { // Json/Loader
    internal sealed class PlayerClassesLoader : LoaderBase<PlayerClass.PlayerClassJsonData> {
        #region Konstruktor
        public PlayerClassesLoader(Main aParent, Enumerations.LanguageEnum aLanguage)
            : base(aParent, aLanguage) { }
        #endregion

        #region Methoden
        public List<PlayerClassData> LoadData(string aPathName) {
            List<PlayerClassData> lResult = new();
            uint lSortOrder = 0;

            base.LoadData(aPathName, 0);
            base.RemoveEmpty();
            base.Check4Dublicates();

            foreach (PlayerClass.PlayerClassJsonData lJsonData in base.JsonData.OrderBy(x => x.Name)) {
                lResult.Add(new PlayerClassData(lJsonData, lSortOrder++));
            }

            return lResult;
        }
        #endregion
    }
}