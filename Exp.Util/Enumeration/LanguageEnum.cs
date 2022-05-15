namespace Exp.Util {
    public sealed class LanguageEnum : EnumerationBase {
        #region Properties / Felder
        #region Static
        internal static LanguageEnum None = new(-1, nameof(None), string.Empty);
        public static LanguageEnum Deutsch = new(0, nameof(Deutsch), "de");
        public static LanguageEnum English = new(1, nameof(English), "en");
        #endregion

        #region Instance
        public string ISO { get; init; }
        #endregion
        #endregion

        #region Konstruktor
        private LanguageEnum(int aID, string aLanguage, string aISO)
            : base(aID, aLanguage, string.Empty)
            => ISO = aISO;
        #endregion

        #region Methoden
        public static List<LanguageEnum> Enumerate() {
            return EnumerationBase.Enumerate<LanguageEnum>(SortDirectionEnum.ASC);
        }

        public static int Count() {
            return EnumerationBase.Count<LanguageEnum>();
        }

        public static LanguageEnum Convert(int aID) {
            return EnumerationBase.Convert<LanguageEnum>(aID, None);
        }

        public static LanguageEnum Convert(string aName) {
            return EnumerationBase.Convert<LanguageEnum>(aName, None);
        }
        #endregion
    }
}