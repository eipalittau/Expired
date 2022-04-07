namespace RtD.Data {
    public sealed class FightTypeEnum : Enumerations.EnumerationBase {
        #region Properties / Felder
        internal static FightTypeEnum None = new FightTypeEnum(0, nameof(None), string.Empty);
        public static FightTypeEnum Melee = new FightTypeEnum(1, "Nahkampf", "");
        public static FightTypeEnum Ranged = new FightTypeEnum(2, "Fernkampf", "");
        //public static FightTypeEnum Both = new FightTypeEnum(3, "Beide", "");
        #endregion

        #region Konstruktor
        private FightTypeEnum(byte aID, string aName, string aDescription)
            : base(aID, aName, aDescription) { }
        #endregion

        #region Methoden
        public static List<FightTypeEnum> Enumerate() {
            return Enumerations.EnumerationBase.Enumerate<FightTypeEnum>(DirectionEnum.ASC);
        }

        public static List<FightTypeEnum> Enumerate(DirectionEnum aDirection) {
            return Enumerations.EnumerationBase.Enumerate<FightTypeEnum>(aDirection);
        }

        public static int Count() {
            return Enumerations.EnumerationBase.Count<FightTypeEnum>();
        }

        public static FightTypeEnum Convert(int aID) {
            return Enumerations.EnumerationBase.Convert<FightTypeEnum>(aID, None);
        }

        public static FightTypeEnum Convert(string? aName) {
            return Enumerations.EnumerationBase.Convert<FightTypeEnum>(aName ?? string.Empty, None);
        }
        #endregion
    }
}