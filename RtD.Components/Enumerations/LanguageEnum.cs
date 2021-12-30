namespace RtD.Enumerations
{
    public sealed class LanguageEnum : EnumerationBase
    {
        #region Properties / Felder
        internal static LanguageEnum None = new LanguageEnum(0, string.Empty, nameof(None));
        public static LanguageEnum Deutsch = new LanguageEnum(1, "de", nameof(Deutsch));
        public static LanguageEnum English = new LanguageEnum(2, "en", nameof(English));

        public string ISO { get; set; }
        #endregion

        #region Konstruktor
        private LanguageEnum(byte aID, string aISO, string aName)
            : base(aID, aName)
            => ISO = aISO;
        #endregion

        #region Methoden
        public static List<LanguageEnum> Enumerate() {
            return Enumerations.EnumerationBase.Enumerate<LanguageEnum>(DirectionEnum.None);
        }

        public static List<LanguageEnum> Enumerate(DirectionEnum aDirection) {
            return Enumerations.EnumerationBase.Enumerate<LanguageEnum>(aDirection);
        }

        public static int Count() {
            return Enumerations.EnumerationBase.Count<LanguageEnum>();
        }
        #endregion
    }
}