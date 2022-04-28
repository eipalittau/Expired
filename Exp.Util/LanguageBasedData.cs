namespace Exp.Util {
    public sealed class LanguageBasedData {
        #region Properties / Felder
        private readonly string[] mValue = new string[LanguageEnum.Count()];
        #endregion

        #region Konstruktor
        public LanguageBasedData() { }
        #endregion

        #region Methoden
        public void Set(LanguageEnum aLanguage, string aValue) {
            mValue[aLanguage.ID] = aValue;
        }

        public string Get(LanguageEnum aLanguage) {
            return string.Concat(@"{\rtf1", mValue[aLanguage.ID], @"}");
        }

        public string? Get(string aValue) {
            return mValue.Where(x => x.Equals(aValue, StringComparison.InvariantCultureIgnoreCase)).FirstOrDefault();
        }
        #endregion
    }
}