namespace Exp.Data.General {
    public sealed class LanguageBasedData {
        #region Properties / Felder
        private string[] mValue = new string[LanguageEnum.Count()];
        #endregion

        #region Konstruktor
        public LanguageBasedData() { }
        #endregion

        #region Methoden
        public void Value(LanguageEnum aLanguage, string aValue) {
            mValue[GetEnumValueAsInt(aLanguage)] = aValue;
        }

        Public string Value(LanguageEnum aLanguage) {
            return mValue[GetEnumValueAsInt(aLanguage)];
        }

        private int GetEnumValueAsInt(LanguageEnum aLanguage) {
            if () {
                return (int)aLanguage;
            } else {
                throw new Exception; //OutOfBound
            }
        }
        #endregion
    }
}
