using Exp.Util.Enumeration;

namespace Exp.Util {
    public sealed class LanguageBasedData {
        #region Properties / Felder
        private readonly string[] mValue = new string[LanguageEnum.Count()];
        #endregion

        #region Methoden
        public void Set(LanguageEnum aLanguage, string aValue) {
            if (string.IsNullOrWhiteSpace(aValue)) {
                ExceptionHandler.Add(new Exception.MissingParameterException(nameof(aValue)));
            }
            mValue[aLanguage.Index] = aValue;
        }

        public string Get(LanguageEnum aLanguage) {
            return mValue[aLanguage.Index];
            //return string.Concat(@"{\rtf1", mValue[aLanguage.ID], @"}");
        }

        public string? Get(string aValue) {
            return Array.Find(mValue, x => x.Equals(aValue, StringComparison.InvariantCultureIgnoreCase));
        }

        public string Get() {
            return Get(LanguageEnum.GetDefault());
        }
        #endregion
    }
}