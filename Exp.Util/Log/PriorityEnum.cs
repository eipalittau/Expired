using Exp.Util.Enumeration.Base;

namespace Exp.Util
{
    public sealed class PriorityEnum : EnumerationBase {
        #region Properties / Felder
        public static PriorityEnum None = new(nameof(None));
        public static PriorityEnum Debug = new(nameof(Debug));
        public static PriorityEnum Information = new(nameof(Information));
        public static PriorityEnum Warning = new(nameof(Warning));
        public static PriorityEnum Error = new(nameof(Error));

        private static int mIndexCounter = 0;
        #endregion

        #region Konstruktor
        private PriorityEnum(string aName)
            : base(mIndexCounter++, aName, string.Empty) { }
        #endregion

        #region Methoden
        public static List<PriorityEnum> Enumerate() {
            return Enumerate<PriorityEnum>();
        }

        public static int Count() {
            return Count<PriorityEnum>();
        }

        public static PriorityEnum Convert(long aIndex) {
            return Convert(aIndex, None);
        }

        public static PriorityEnum Convert(string aLanguage) {
            return Convert(aLanguage, None);
        }

        public override string ToString() {
            return Name.PadRight(Enumerate().Max(x => x.Name.Length));
        }
        #endregion
    }
}