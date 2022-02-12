namespace RtD.Data.Json {
    internal sealed class LevelUpLoader : LoaderBase<LevelUpJsonData> {
        #region Konstruktor
        public LevelUpLoader(Main aParent, Enumerations.LanguageEnum aLanguage)
            : base(aParent, aLanguage) { }
        #endregion

        #region Methoden
        public LevelUpData LoadData(string aPathName) {
            base.LoadData(aPathName, 0);

            return new LevelUpData(base.JsonData.First());
        }
        #endregion
    }
}