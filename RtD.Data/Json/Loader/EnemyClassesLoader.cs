namespace RtD.Data.Json { // Json/Loader
    internal sealed class EnemyClassesLoader : LoaderBase<EnemyClass.EnemyClassJsonData> {
        #region Konstruktor
        public EnemyClassesLoader(Main aParent, Enumerations.LanguageEnum aLanguage)
            : base(aParent, aLanguage) { }
        #endregion

        #region Methoden
        public List<EnemyClassData> LoadData(string aPathName) {
            List<EnemyClassData> lResult = new();
            uint lSortOrder = 0;

            base.LoadData(aPathName, 0);
            base.RemoveEmpty();
            base.Check4Dublicates();

            foreach (EnemyClass.EnemyClassJsonData lJsonData in base.JsonData
                .OrderBy(x => x.Name)) {
                lResult.Add(new EnemyClassData(lJsonData, lSortOrder++));
            }

            return lResult;
        }
        #endregion
    }
}