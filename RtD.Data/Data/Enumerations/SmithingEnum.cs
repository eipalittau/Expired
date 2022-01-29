namespace RtD.Data {
    //Achtung: Aktiv = hat ItemTypes, passiv = ohne
    public class SmithingEnum : Enumerations.EnumerationBase {
        #region Properties / Felder
        internal static SmithingEnum None = new SmithingEnum(0, nameof(None), string.Empty, 0);
        public static SmithingEnum Sharpening = new SmithingEnum(1, "Schärfen", "", 1, ItemTypeEnum.Onehandweapon, ItemTypeEnum.Twohandweapon, ItemTypeEnum.Bow, ItemTypeEnum.Crossbow, ItemTypeEnum.Arrows, ItemTypeEnum.Bolts, ItemTypeEnum.Dagger);
        public static SmithingEnum Hardening = new SmithingEnum(2, "Härten", "", 1, ItemTypeEnum.Armor, ItemTypeEnum.Boots, ItemTypeEnum.Shield, ItemTypeEnum.Bracers, ItemTypeEnum.Headgear);
        public static SmithingEnum Refining = new SmithingEnum(3, "Veredeln", "", 1, ItemTypeEnum.Ring, ItemTypeEnum.Amulet);
        public static SmithingEnum RaisePower = new SmithingEnum(4, "Machterhöhung", "", 1, ItemTypeEnum.Ring, ItemTypeEnum.Amulet, ItemTypeEnum.Focus, ItemTypeEnum.Tome, ItemTypeEnum.Cloak, ItemTypeEnum.Headgear, ItemTypeEnum.Bracers, ItemTypeEnum.Boots, ItemTypeEnum.Armor);
        public static SmithingEnum CreateBoots = new SmithingEnum(5, "Schiefel schmieden", "", 1, ItemTypeEnum.Boots);
        public static SmithingEnum Upgrading = new SmithingEnum(6, "Aufwertung", "", 1, ItemTypeEnum.Onehandweapon, ItemTypeEnum.Twohandweapon, ItemTypeEnum.Bow, ItemTypeEnum.Crossbow, ItemTypeEnum.Arrows, ItemTypeEnum.Bolts, ItemTypeEnum.Dagger, ItemTypeEnum.Armor, ItemTypeEnum.Boots, ItemTypeEnum.Shield, ItemTypeEnum.Bracers, ItemTypeEnum.Headgear);
        public static SmithingEnum InefficientSmithing = new SmithingEnum(7, "Ineffizientes Schmieden", "", 1);
        public static SmithingEnum EfficientSmithing = new SmithingEnum(8, "Effizientes Schmieden", "", 1);
        public static SmithingEnum ElementalDamage = new SmithingEnum(9, "Elementarschaden", "", 2, Sharpening, ItemTypeEnum.Onehandweapon, ItemTypeEnum.Twohandweapon, ItemTypeEnum.Bow, ItemTypeEnum.Crossbow, ItemTypeEnum.Arrows, ItemTypeEnum.Bolts, ItemTypeEnum.Dagger);
        public static SmithingEnum ElementalArmor = new SmithingEnum(10, "Elementarrüstung", "", 2, Hardening, ItemTypeEnum.Armor, ItemTypeEnum.Boots, ItemTypeEnum.Shield, ItemTypeEnum.Bracers, ItemTypeEnum.Headgear);
        public static SmithingEnum Enlarge = new SmithingEnum(11, "Vergrössern", "", 2, Refining, ItemTypeEnum.Ring);
        public static SmithingEnum InefficientSmithing2 = new SmithingEnum(12, "Sehr ineffizientes Schmieden", "", 2, InefficientSmithing);
        public static SmithingEnum EfficientSmithing2 = new SmithingEnum(13, "Sehr effizientes Schmieden", "", 2, EfficientSmithing);
        public static SmithingEnum Mastersmith = new SmithingEnum(14, "Meisterschmied", "", 3);
        public static SmithingEnum WitchSmithy = new SmithingEnum(15, "Hexenschmiede", "", 3);

        public int Tier { get; }
        public SmithingEnum? Prerequisite { get; }
        public List<ItemTypeEnum> ItemTypeList { get; } = new List<ItemTypeEnum>();
        #endregion

        #region Konstruktor
        private SmithingEnum(byte aID, string aName, string aDescription, int aTier, params ItemTypeEnum[] aItemType)
            : this(aID, aName, aDescription, aTier, null, aItemType) { }

        private SmithingEnum(byte aID, string aName, string aDescription, int aTier, SmithingEnum? aPrerequisite, params ItemTypeEnum[] aItemType)
            : base(aID, aName, aDescription) {
            Tier = aTier;
            Prerequisite = aPrerequisite;

            if (aItemType != null && aItemType.Length > 0) {
                ItemTypeList.AddRange(aItemType);
            }
        }
        #endregion

        #region Methoden
        public static List<SmithingEnum> Enumerate() {
            return Enumerations.EnumerationBase.Enumerate<SmithingEnum>(DirectionEnum.ASC);
        }

        public static List<SmithingEnum> Enumerate(DirectionEnum aDirection) {
            return Enumerations.EnumerationBase.Enumerate<SmithingEnum>(aDirection);
        }

        public static int Count() {
            return Enumerations.EnumerationBase.Count<SmithingEnum>();
        }

        public static SmithingEnum Convert(int aID) {
            return Enumerations.EnumerationBase.Convert<SmithingEnum>(aID, None);
        }

        public static SmithingEnum Convert(string? aName) {
            return Enumerations.EnumerationBase.Convert<SmithingEnum>(aName ?? string.Empty, None);
        }
        #endregion
    }
}