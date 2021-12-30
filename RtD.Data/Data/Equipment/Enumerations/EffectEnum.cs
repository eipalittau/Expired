namespace RtD.Data {
    public sealed class EffectEnum : Enumerations.EnumerationBase {
        #region Properties / Felder
        internal static EffectEnum None = new EffectEnum(0, nameof(None));
        public static EffectEnum Primary = new EffectEnum(1, "Primär");
        public static EffectEnum Secondary = new EffectEnum(2, "Sekundär");
        #endregion

        #region Konstruktor
        private EffectEnum(byte aID, string aName)
            : base(aID, aName, string.Empty) { }
        #endregion

        #region Methoden
        public static List<EffectEnum> Enumerate() {
            return Enumerations.EnumerationBase.Enumerate<EffectEnum>(DirectionEnum.ASC);
        }

        public static List<EffectEnum> Enumerate(DirectionEnum aDirection) {
            return Enumerations.EnumerationBase.Enumerate<EffectEnum>(aDirection);
        }

        public static int Count() {
            return Enumerations.EnumerationBase.Count<EffectEnum>();
        }

        public static EffectEnum Convert(int aID) {
            return Enumerations.EnumerationBase.Convert<EffectEnum>(aID, None);
        }

        public static EffectEnum Convert(string? aName) {
            return Enumerations.EnumerationBase.Convert<EffectEnum>(aName ?? string.Empty, None);
        }
        #endregion

    }
}