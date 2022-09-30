using System.Globalization;
using Exp.Util.Enumeration.Base;

namespace Exp.Util
{
    public sealed class LanguageEnum : EnumerationBase {
        #region Properties / Felder
        #region Static
        internal readonly static LanguageEnum None = new(nameof(None), string.Empty);
        public readonly static LanguageEnum Deutsch = new(nameof(Deutsch), "de", true);
        public readonly static LanguageEnum English = new(nameof(English), "en");

        private static int mIndexCounter = -1;
        #endregion

        #region Instance
        public string ISO { get; init; }
        public CultureInfo CI { get; init; }
        internal bool IsDefault { get; init; }
        #endregion
        #endregion

        #region Konstruktor
        private LanguageEnum(string aLanguage, string aISO)
            : base(mIndexCounter++, aLanguage, string.Empty)
            => (ISO, CI) = (aISO, new CultureInfo(aISO));

        private LanguageEnum(string aLanguage, string aISO, bool aIsDefault)
            : this(aLanguage, aISO)
            => IsDefault = aIsDefault;
        #endregion

        #region Methoden
        public static LanguageEnum GetDefault() {
            return Enumerate().Where(x => x.IsDefault).First();
        }

        public static List<LanguageEnum> Enumerate() {
            return EnumerateByName<LanguageEnum>(SortDirectionEnum.ASC);
        }

        public static int Count() {
            return Count<LanguageEnum>();
        }

        public static LanguageEnum Convert(long aIndex) {
            return Convert(aIndex, None);
        }

        public static LanguageEnum Convert(string aName) {
            return Convert(aName, None);
        }
        #endregion
    }
}