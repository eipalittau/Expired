namespace RtD.Data {
    public sealed class RangeEnum : Enumerations.EnumerationBase {
        #region Properties / Felder
        internal static RangeEnum None = new RangeEnum(0, nameof(None));
        public static RangeEnum Item = new RangeEnum(1, "Item");
        public static RangeEnum Character = new RangeEnum(2, "Character");
        #endregion

        #region Konstruktor
        private RangeEnum(byte aID, string aName)
            : base(aID, aName, string.Empty) { }
        #endregion

        #region Methoden
        public static List<RangeEnum> Enumerate() {
            return Enumerations.EnumerationBase.Enumerate<RangeEnum>(DirectionEnum.ASC);
        }

        public static List<RangeEnum> Enumerate(DirectionEnum aDirection) {
            return Enumerations.EnumerationBase.Enumerate<RangeEnum>(aDirection);
        }

        public static int Count() {
            return Enumerations.EnumerationBase.Count<RangeEnum>();
        }

        public static RangeEnum Convert(int aID) {
            return Enumerations.EnumerationBase.Convert<RangeEnum>(aID, None);
        }

        public static RangeEnum Convert(string? aName) {
            return Enumerations.EnumerationBase.Convert<RangeEnum>(aName ?? string.Empty, None);
        }
        #endregion
    }
}