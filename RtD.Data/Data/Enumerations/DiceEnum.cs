namespace RtD.Data
{
    public class DiceEnum : Enumerations.EnumerationBase
    {
        #region Properties / Felder
        internal static DiceEnum None = new DiceEnum(0, nameof(None), string.Empty, 0);
        public static DiceEnum Dice4 = new DiceEnum(1, "1W4", "4-seitiger Würfel", 4);
        public static DiceEnum Dice6 = new DiceEnum(2, "1W6", "6-seitiger Würfel", 6);
        public static DiceEnum Dice8 = new DiceEnum(3, "1W8", "8-seitiger Würfel", 8);
        public static DiceEnum Dice10 = new DiceEnum(4, "1W10", "10-seitiger Würfel", 10);
        public static DiceEnum Dice12 = new DiceEnum(5, "1W12", "12-seitiger Würfel", 12);
        public static DiceEnum Dice20 = new DiceEnum(6, "1W20", "20-seitiger Würfel", 20);
        public static DiceEnum Dice100 = new DiceEnum(7, "1W100", "100-seitiger Würfel", 100);

        public int Faces { get; private set; }
        #endregion

        #region Konstruktor
        private DiceEnum(byte aID, string aName, string aDescription, int aFaces)
            : base(aID, aName, aDescription)
            => (Description, Faces) = (aDescription, aFaces);
        #endregion

        #region Methoden
        public static List<DiceEnum> Enumerate()
        {
            return Enumerations.EnumerationBase.Enumerate<DiceEnum>(DirectionEnum.None);
        }

        public static List<DiceEnum> Enumerate(DirectionEnum aDirection)
        {
            return Enumerations.EnumerationBase.Enumerate<DiceEnum>(aDirection);
        }

        public static int Count()
        {
            return Enumerations.EnumerationBase.Count<DiceEnum>();
        }

        public static DiceEnum Convert(int aID) {
            return Enumerations.EnumerationBase.Convert<DiceEnum>(aID, None);
        }

        public static DiceEnum Convert(string? aName) {
            return Enumerations.EnumerationBase.Convert<DiceEnum>(aName ?? string.Empty, None);
        }

        public int Roll()
        {
            return new Random().Next(1, Faces);
        }
        #endregion
    }
}