namespace Exp.Util {
    public sealed class LanguageBasedData {
        #region Properties / Felder
        private readonly string[] mValue = new string[LanguageEnum.Count()];
        #endregion

        #region Konstruktor
        public LanguageBasedData() { }
        #endregion
        //Patrik: Statische Klasse f�r Exception aufrufen, welche wahlweise Throw ausf�hrt oder diese sammelt.
        #region Methoden
        public void Set(LanguageEnum aLanguage, string aValue) {
            if (string.IsNullOrWhiteSpace(aValue)) {
                //Patrik: Exception werfen.
            }
            mValue[aLanguage.ID] = aValue;
        }

        public string Get(LanguageEnum aLanguage) {
            return string.Concat(@"{\rtf1", mValue[aLanguage.ID], @"}");
        }

        public string? Get(string aValue) {
            return mValue.Where(x => x.Equals(aValue, StringComparison.InvariantCultureIgnoreCase)).FirstOrDefault();
        }

        public string Get() {
            return Get(LanguageEnum.Deutsch);
        }
        #endregion
    }
}