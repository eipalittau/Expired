namespace Exp.Util {
    public sealed class LanguageEnum : EnumerationMethodBase {
        #region Properties / Felder
        #region Static
        internal static LanguageEnum None = new(-1, nameof(None), string.Empty);
        public static LanguageEnum Fallback = new(0, nameof(Fallback), string.Empty);
        public static LanguageEnum Deutsch = new(1, nameof(Deutsch), "de-DE");
        public static LanguageEnum English = new(2, nameof(English), "en-EN");
        #endregion

        #region Instance
        public int ID { get; init; }
        public string Language { get; init; }
        public string ISO { get; init; }
        #endregion
        #endregion

        #region Konstruktor
        private LanguageEnum(int aID, string aLanguage, string aISO)
            => (ID, Language, ISO) = (aID, aLanguage, aISO);
        #endregion

        #region Methoden
        public static List<LanguageEnum> Enumerate() {
            return EnumerationMethodBase.Enumerate<LanguageEnum>().OrderBy(x => x.ID).ToList();
        }

        public static int Count() {
            return EnumerationMethodBase.Count<LanguageEnum>();
        }

        public static LanguageEnum Convert(int aID) {
            return Enumerate().Where(x => x.ID == aID).FirstOrDefault() ?? None;
        }

        public static LanguageEnum Convert(string aLanguage) {
            return Enumerate().Where(x => x.Language == aLanguage).FirstOrDefault() ?? None;
        }

        public override string ToString() {
            return Language;
        }
        #endregion
    }
}