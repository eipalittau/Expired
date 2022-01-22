namespace RtD.Data {
    public class DamageTypeEnum : Enumerations.EnumerationBase {
        #region Properties / Felder
        internal static DamageTypeEnum None = new DamageTypeEnum(0, nameof(None), string.Empty);
        public static DamageTypeEnum Meele = new DamageTypeEnum(1, "Nahkampf", "");
        public static DamageTypeEnum Ranged = new DamageTypeEnum(2, "Fernkampf", "");
        public static DamageTypeEnum Magic = new DamageTypeEnum(3, "Magie", "");
        #endregion

        #region Konstruktor
        private DamageTypeEnum(byte aID, string aName, string aDescription)
            : base(aID, aName, aDescription) { }
        #endregion
        //TODO: Patrik: Methoden umsetzen.
        #region Methoden
        public static List<DamageTypeEnum> Enumerate() {
            return Enumerations.EnumerationBase.Enumerate<DamageTypeEnum>(DirectionEnum.ASC);
        }

        public static List<DamageTypeEnum> Enumerate(DirectionEnum aDirection) {
            return Enumerations.EnumerationBase.Enumerate<DamageTypeEnum>(aDirection);
        }

        public static int Count() {
            return Enumerations.EnumerationBase.Count<DamageTypeEnum>();
        }

        public static DamageTypeEnum Convert(int aID) {
            return Enumerations.EnumerationBase.Convert<DamageTypeEnum>(aID, None);
        }

        public static DamageTypeEnum Convert(string? aName) {
            return Enumerations.EnumerationBase.Convert<DamageTypeEnum>(aName ?? string.Empty, None);
        }
        #endregion
    }
}