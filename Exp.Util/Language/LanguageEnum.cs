using System.Globalization;

namespace Exp.Util {
    public sealed class LanguageEnum : EnumerationBase {
        #region Properties / Felder
        #region Static
        internal static LanguageEnum None = new(-1, nameof(None), string.Empty);
        public static LanguageEnum Deutsch = new(0, nameof(Deutsch), "de", true);
        public static LanguageEnum English = new(1, nameof(English), "en");
        #endregion

        #region Instance
        public string ISO { get; init; }
        public CultureInfo CI { get; init; }
        internal bool IsDefault { get; init; }
        #endregion
        #endregion

        #region Konstruktor
        private LanguageEnum(int aID, string aLanguage, string aISO)
            : base(aID, aLanguage, string.Empty)
            => (ISO, CI) = (aISO, new CultureInfo(aISO));

        private LanguageEnum(int aID, string aLanguage, string aISO, bool aIsDefault)
            : this(aID, aLanguage, aISO)
            => IsDefault = aIsDefault;
        #endregion

        #region Methoden
        public static LanguageEnum GetDefault() {
            return Enumerate().Where(x => x.IsDefault).First();
        }

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