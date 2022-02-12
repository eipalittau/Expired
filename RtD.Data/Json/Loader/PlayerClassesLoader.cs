namespace RtD.Data.Json {
    internal sealed class PlayerClassesLoader : LoaderBase<PlayerClassJsonData> {
        #region Konstruktor
        public PlayerClassesLoader(Main aParent, Enumerations.LanguageEnum aLanguage)
            : base(aParent, aLanguage) { }
        #endregion

        #region Methoden
        public List<EnemyClassData> LoadData(string aPathName) {
            List<PlayerClassData> lResult = new();
            uint lSortOrder = 0;

            base.LoadData(aPathName, 0);
            base.RemoveEmpty();
            base.Check4Dublicates();

            foreach (PlayerClassJsonData lJsonData in base.JsonData
                .OrderBy(x => x.Name)) {
                lResult.Add(new EnemyClassData(lJsonData, lSortOrder++));
            }

            return lResult;
        }
        #endregion
    }
}