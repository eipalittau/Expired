namespace RtD.Data {
    public class ItemTypeEnum : Enumerations.EnumerationBase {
        #region Properties / Felder
        internal static ItemTypeEnum None = new ItemTypeEnum(0, nameof(None), string.Empty, EquipmentSlotEnum.None);
        public static ItemTypeEnum Armor = new ItemTypeEnum(1, "Rüstung", "", EquipmentSlotEnum.Armor);
        public static ItemTypeEnum Boots = new ItemTypeEnum(2, "Stiefel", "", EquipmentSlotEnum.Feet);

        public static ItemTypeEnum Onehandweapon = new ItemTypeEnum(3, "Einhandwaffe", "", EquipmentSlotEnum.Mainhand, EquipmentSlotEnum.Offhand);
        public static ItemTypeEnum Twohandweapon = new ItemTypeEnum(4, "Zweihandwaffe", "", EquipmentSlotEnum.Mainhand, EquipmentSlotEnum.Offhand);
        public static ItemTypeEnum Bow = new ItemTypeEnum(5, "Bogen", "", EquipmentSlotEnum.Mainhand, EquipmentSlotEnum.Offhand);
        public static ItemTypeEnum Crossbow = new ItemTypeEnum(6, "Armbrust", "", EquipmentSlotEnum.Mainhand, EquipmentSlotEnum.Offhand);
        public static ItemTypeEnum Arrows = new ItemTypeEnum(7, "Pfeile", "", Bow, EquipmentSlotEnum.Mainhand, EquipmentSlotEnum.Offhand);
        public static ItemTypeEnum Bolts = new ItemTypeEnum(8, "Bolzen", "", Crossbow, EquipmentSlotEnum.Mainhand, EquipmentSlotEnum.Offhand);

        public static ItemTypeEnum Dagger = new ItemTypeEnum(9, "Dolch", "", EquipmentSlotEnum.Offhand);
        public static ItemTypeEnum Shield = new ItemTypeEnum(10, "Schild", "", EquipmentSlotEnum.Offhand);
        public static ItemTypeEnum Focus = new ItemTypeEnum(11, "Heiliges Symbol", "", EquipmentSlotEnum.Offhand);
        public static ItemTypeEnum Tome = new ItemTypeEnum(12, "Zauberbuch", "", EquipmentSlotEnum.Offhand);

        public static ItemTypeEnum Ring = new ItemTypeEnum(13, "Ring", "", EquipmentSlotEnum.RingFingerLeft, EquipmentSlotEnum.RingFingerRight);
        public static ItemTypeEnum Amulet = new ItemTypeEnum(14, "Amulett", "", EquipmentSlotEnum.Neck);
        public static ItemTypeEnum Cloak = new ItemTypeEnum(15, "Umhang", "", EquipmentSlotEnum.Shoulders);
        public static ItemTypeEnum Headgear = new ItemTypeEnum(16, "Kopfbedeckung", "", EquipmentSlotEnum.Head);
        public static ItemTypeEnum Bracers = new ItemTypeEnum(17, "Armschutz", "", EquipmentSlotEnum.WristLeft, EquipmentSlotEnum.WristRight);
        public static ItemTypeEnum Consumable = new ItemTypeEnum(18, "Konsumierbar", "", EquipmentSlotEnum.Bag);

        public List<EquipmentSlotEnum> EquipmentSlot { get; } = new List<EquipmentSlotEnum>();
        public ItemTypeEnum? Parent { get; private set; }
        #endregion

        #region Konstruktor
        private ItemTypeEnum(byte aID, string aName, string aDescription, params EquipmentSlotEnum[] aEquipmentSlot)
            : this(aID, aName, aDescription, null, aEquipmentSlot) { }

        private ItemTypeEnum(byte aID, string aName, string aDescription, ItemTypeEnum? aParent, params EquipmentSlotEnum[] aEquipmentSlot)
            : base(aID, aName, aDescription)
            => (EquipmentSlot, Parent) = (aEquipmentSlot.ToList(), aParent);
        #endregion

        #region Methoden
        public static List<ItemTypeEnum> Enumerate() {
            return Enumerations.EnumerationBase.Enumerate<ItemTypeEnum>(DirectionEnum.ASC);
        }

        public static List<ItemTypeEnum> Enumerate(DirectionEnum aDirection) {
            return Enumerations.EnumerationBase.Enumerate<ItemTypeEnum>(aDirection);
        }

        public static int Count() {
            return Enumerations.EnumerationBase.Count<ItemTypeEnum>();
        }

        public static ItemTypeEnum Convert(int aID) {
            return Enumerations.EnumerationBase.Convert<ItemTypeEnum>(aID, None);
        }

        public static ItemTypeEnum Convert(string? aName) {
            return Enumerations.EnumerationBase.Convert<ItemTypeEnum>(aName ?? string.Empty, None);
        }
        #endregion
    }
}