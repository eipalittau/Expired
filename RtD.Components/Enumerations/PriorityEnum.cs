namespace RtD.Enumerations
{
    public sealed class PriorityEnum : EnumerationBase
    {
        #region Properties / Felder
        internal static PriorityEnum None = new(0, nameof(None));
        public static PriorityEnum Debug = new(1, nameof(Debug));
        public static PriorityEnum Information = new(2, nameof(Information));
        public static PriorityEnum Warning = new(3, nameof(Warning));
        public static PriorityEnum Critical = new(4, nameof(Critical));
        #endregion

        #region Konstruktor
        private PriorityEnum(byte aID, string aName)
            : base(aID, aName) { }
        #endregion

        #region Methoden
        public static List<PriorityEnum> Enumerate() {
            return Enumerations.EnumerationBase.Enumerate<PriorityEnum>(DirectionEnum.None);
        }

        public static List<PriorityEnum> Enumerate(DirectionEnum aDirection) {
            return Enumerations.EnumerationBase.Enumerate<PriorityEnum>(aDirection);
        }

        public static int Count() {
            return Enumerations.EnumerationBase.Count<PriorityEnum>();
        }

        public override string ToString()
        {
            return Name.PadRight(Information.Name.Length - Name.Length, ' ');
        }
        #endregion
    }
}