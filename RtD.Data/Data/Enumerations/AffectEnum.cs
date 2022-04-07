namespace RtD.Data {
    public class AffectEnum : Enumerations.EnumerationBase {
        #region Properties / Felder
        internal static AffectEnum None = new AffectEnum(0, nameof(None));
        public static AffectEnum Character = new AffectEnum(1, "Charakter");
        #endregion

        #region Konstruktor
        private AffectEnum(byte aID, string aName)
            : base(aID, aName, String.Empty) { }
        #endregion

        #region Methoden
        public static List<AffectEnum> Enumerate() {
            return Enumerations.EnumerationBase.Enumerate<AffectEnum>(DirectionEnum.ASC);
        }

        public static List<AffectEnum> Enumerate(DirectionEnum aDirection) {
            return Enumerations.EnumerationBase.Enumerate<AffectEnum>(aDirection);
        }

        public static int Count() {
            return Enumerations.EnumerationBase.Count<AffectEnum>();
        }

        public static AffectEnum Convert(int aID) {
            return Enumerations.EnumerationBase.Convert<AffectEnum>(aID, None);
        }

        public static AffectEnum Convert(string? aName) {
            return Enumerations.EnumerationBase.Convert<AffectEnum>(aName ?? string.Empty, None);
        }
        #endregion
    }
}