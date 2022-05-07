namespace Exp.Util {
    public sealed class PriorityEnum : EnumerationBase {
        #region Properties / Felder
        internal static PriorityEnum None = new(-1, nameof(None));
        public static PriorityEnum Debug = new(0, nameof(Debug));
        public static PriorityEnum Information = new(1, nameof(Information));
        public static PriorityEnum Warning = new(2, nameof(Warning));
        public static PriorityEnum Error = new(2, nameof(Error));
        #endregion

        #region Konstruktor
        private PriorityEnum(int aID, string aName)
            : base(aID, aName, string.Empty) { }
        #endregion

        #region Methoden
        public static List<PriorityEnum> Enumerate() {
            return EnumerationBase.Enumerate<PriorityEnum>();
        }

        public static int Count() {
            return EnumerationBase.Count<PriorityEnum>();
        }

        public static PriorityEnum Convert(int aID) {
            return EnumerationBase.Convert<PriorityEnum>(aID, None);
        }

        public static PriorityEnum Convert(string aLanguage) {
            return EnumerationBase.Convert<PriorityEnum>(aLanguage, None);
        }
        #endregion
    }
}