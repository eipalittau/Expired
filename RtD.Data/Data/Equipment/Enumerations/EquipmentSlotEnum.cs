namespace RtD.Data {
    public sealed class EquipmentSlotEnum : Enumerations.EnumerationBase {
        #region Properties / Felder
        internal static EquipmentSlotEnum None = new EquipmentSlotEnum(0, nameof(None), string.Empty);
        public static EquipmentSlotEnum Armor = new EquipmentSlotEnum(1, "Rüstung", "Schützt vor Angriffen");
        public static EquipmentSlotEnum Feet = new EquipmentSlotEnum(2, "Füsse", "Für Schuhe", false);
        public static EquipmentSlotEnum Mainhand = new EquipmentSlotEnum(3, "Haupthand", "Die starke Hand");
        public static EquipmentSlotEnum Offhand = new EquipmentSlotEnum(4, "Nebenhand", "Die schwache Hand");
        public static EquipmentSlotEnum RingFingerLeft = new EquipmentSlotEnum(5, "Ringfinger links", "Für Schmuck");
        public static EquipmentSlotEnum RingFingerRight = new EquipmentSlotEnum(6, "Ringfinger rechts", "Für Schmuck");
        public static EquipmentSlotEnum WristLeft = new EquipmentSlotEnum(7, "Handgelenk links", "Für Schmuck", false);
        public static EquipmentSlotEnum WristRight = new EquipmentSlotEnum(8, "Handgelenk rechts", "Für Schmuck", false);
        public static EquipmentSlotEnum Neck = new EquipmentSlotEnum(9, "Hals", "Für Schmuck");
        public static EquipmentSlotEnum Shoulders = new EquipmentSlotEnum(10, "Schultern", "Für ein Cape wie es Superman hat");
        public static EquipmentSlotEnum Head = new EquipmentSlotEnum(11, "Kopf", "Für Schmuck");
        public static EquipmentSlotEnum Bag = new EquipmentSlotEnum(12, "Tasche", "Für alles andere");

        public bool Available { get; set; }

        private static uint mLastSortIndex = 0;
        #endregion

        #region Konstruktor
        private EquipmentSlotEnum(byte aID, string aName, string aDescription)
            : this(aID, aName, aDescription, true) { }

        private EquipmentSlotEnum(byte aID, string aName, string aDescription, bool aAvailable)
            : base(aID, aName, aDescription, ++mLastSortIndex)
            => Available = aAvailable;
        #endregion

        #region Methoden
        public static List<EquipmentSlotEnum> Enumerate()
        {
            return Enumerations.EnumerationBase.Enumerate<EquipmentSlotEnum>(DirectionEnum.ASC);
        }

        public static List<EquipmentSlotEnum> Enumerate(DirectionEnum aDirection)
        {
            return Enumerations.EnumerationBase.Enumerate<EquipmentSlotEnum>(aDirection);
        }

        public static int Count()
        {
            return Enumerations.EnumerationBase.Count<EquipmentSlotEnum>();
        }

        public static EquipmentSlotEnum Convert(int aID) {
            return Enumerations.EnumerationBase.Convert<EquipmentSlotEnum>(aID, None);
        }

        public static EquipmentSlotEnum Convert(string? aName) {
            return Enumerations.EnumerationBase.Convert<EquipmentSlotEnum>(aName ?? string.Empty, None);
        }
        #endregion
    }
}