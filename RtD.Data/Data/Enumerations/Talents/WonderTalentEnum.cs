namespace RtD.Data {
    public class WonderTalentEnum : TalentEnumBase<WonderTalentEnum>, ITalent {
        #region Properties / Felder
        internal static WonderTalentEnum None = new WonderTalentEnum(0, nameof(None), string.Empty, 0);
        public static WonderTalentEnum IceArmor = new WonderTalentEnum(1, "Eisrüstung", "", 1);
        public static WonderTalentEnum MagicWeapon = new WonderTalentEnum(2, "Magische Waffe", "", 1, ActionTypeEnum.Standard);
        public static WonderTalentEnum MiracleDoll = new WonderTalentEnum(3, "Wunderpuppe", "", 1, ActionTypeEnum.Standard);
        public static WonderTalentEnum ThingT = new WonderTalentEnum(4, "Eiskaltes Händchen", "", 1, ActionTypeEnum.Standard); //Englische Übersetzung aus "Addams Family"
        public static WonderTalentEnum Haste = new WonderTalentEnum(5, "Hast", "", 1, ActionTypeEnum.Standard);
        public static WonderTalentEnum Lubricate = new WonderTalentEnum(6, "Schmieren", "", 1, ActionTypeEnum.Standard);
        public static WonderTalentEnum MiracleFocus = new WonderTalentEnum(7, "Wunderfokus", "", 1);
        public static WonderTalentEnum MiraculousPower = new WonderTalentEnum(8, "Wundermacht", "", 1);
        public static WonderTalentEnum DiamondArmor = new WonderTalentEnum(9, "Diamantrüstung", "", 2);
        public static WonderTalentEnum AccurateWeapon = new WonderTalentEnum(10, "Zielsichere Waffe", "", 2);
        public static WonderTalentEnum ChannelingNegativeEnergy = new WonderTalentEnum(11, "Negative Energie Kanalisieren", "", 2, ActionTypeEnum.Standard);
        public static WonderTalentEnum Mob = new WonderTalentEnum(12, "Horde", "", 2, ActionTypeEnum.Standard);
        public static WonderTalentEnum Brains = new WonderTalentEnum(13, "BRAINZZZZ!", "", 2, ActionTypeEnum.Full);
        public static WonderTalentEnum MiracleFocus2 = new WonderTalentEnum(14, "Wunderfokus++", "", 2, MiracleFocus);
        public static WonderTalentEnum MiraculousPower2 = new WonderTalentEnum(15, "Wundermacht++", "", 2, MiraculousPower);
        public static WonderTalentEnum Tartaros = new WonderTalentEnum(16, "Tartaros", "", 3);
        public static WonderTalentEnum Nyx = new WonderTalentEnum(17, "Nyx", "", 3);
        public static WonderTalentEnum Styx = new WonderTalentEnum(18, "Styx", "", 3, ActionTypeEnum.Standard);
        #endregion

        #region Konstruktor
        private WonderTalentEnum(byte aID, string aName, string aDescription, int aTier)
            : base(aID, aName, aDescription, aTier, null, null) { }

        private WonderTalentEnum(byte aID, string aName, string aDescription, int aTier, ActionTypeEnum? aActionType)
            : base(aID, aName, aDescription, aTier, aActionType, null) { }

        private WonderTalentEnum(byte aID, string aName, string aDescription, int aTier, params WonderTalentEnum[]? aPrerequisite)
            : base(aID, aName, aDescription, aTier, null, aPrerequisite) { }

        private WonderTalentEnum(byte aID, string aName, string aDescription, int aTier, ActionTypeEnum? aActionType, params WonderTalentEnum[]? aPrerequisite)
            : base(aID, aName, aDescription, aTier, aActionType, aPrerequisite) { }
        #endregion

        #region Methoden
        public static List<WonderTalentEnum> Enumerate() {
            return Enumerations.EnumerationBase.Enumerate<WonderTalentEnum>(DirectionEnum.ASC);
        }

        public static List<WonderTalentEnum> Enumerate(DirectionEnum aDirection) {
            return Enumerations.EnumerationBase.Enumerate<WonderTalentEnum>(aDirection);
        }

        public static int Count() {
            return Enumerations.EnumerationBase.Count<WonderTalentEnum>();
        }

        public static WonderTalentEnum Convert(int aID) {
            return Enumerations.EnumerationBase.Convert<WonderTalentEnum>(aID, None);
        }

        public static WonderTalentEnum Convert(string? aName) {
            return Enumerations.EnumerationBase.Convert<WonderTalentEnum>(aName ?? string.Empty, None);
        }
        #endregion
    }
}