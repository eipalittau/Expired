namespace Exp.Util {
    public sealed class PriorityEnum : EnumerationBase {
        #region Properties / Felder
        public static PriorityEnum None = new(0, nameof(None));
        public static PriorityEnum Debug = new(1, nameof(Debug));
        public static PriorityEnum Information = new(2, nameof(Information));
        public static PriorityEnum Warning = new(3, nameof(Warning));
        public static PriorityEnum Error = new(4, nameof(Error));
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

        public override string ToString() {
            return Name.PadRight(Enumerate().Max(x => x.Name.Length));
        }
        #endregion
    }
}