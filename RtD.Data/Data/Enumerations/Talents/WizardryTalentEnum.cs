namespace RtD.Data {
    public class WizardryTalentEnum : TalentEnumBase<WizardryTalentEnum> {
        #region Properties / Felder
        internal static WizardryTalentEnum None = new WizardryTalentEnum(0, nameof(None), string.Empty, 0);
        public static WizardryTalentEnum MagicWave = new WizardryTalentEnum(1, "Magische Welle", "", 1, ActionTypeEnum.Standard);
        public static WizardryTalentEnum StinkyCloud = new WizardryTalentEnum(2, "Stinkende Wolke", "", 1, ActionTypeEnum.Standard);
        public static WizardryTalentEnum Reflection = new WizardryTalentEnum(3, "Spiegelbild", "", 1, ActionTypeEnum.Standard);
        public static WizardryTalentEnum Shield = new WizardryTalentEnum(4, "Schild", "", 1, ActionTypeEnum.Free);
        public static WizardryTalentEnum Fright = new WizardryTalentEnum(5, "Schrek", "", 1, ActionTypeEnum.Standard);
        public static WizardryTalentEnum FitOfLaughter = new WizardryTalentEnum(6, "Lachanfall", "", 1, ActionTypeEnum.Standard);
        public static WizardryTalentEnum SpellFocus = new WizardryTalentEnum(7, "Zauberfokus", "", 1);
        public static WizardryTalentEnum MagicPower = new WizardryTalentEnum(8, "Zaubermacht", "", 1);
        public static WizardryTalentEnum Icicle = new WizardryTalentEnum(9, "Eiszapfen", "", 2, ActionTypeEnum.Move);
        public static WizardryTalentEnum Fireball = new WizardryTalentEnum(10, "Feuerball", "", 2, ActionTypeEnum.Standard);
        public static WizardryTalentEnum HoldPerson = new WizardryTalentEnum(11, "Person Festhalten", "", 2, ActionTypeEnum.Standard);
        public static WizardryTalentEnum Metamagic = new WizardryTalentEnum(12, "Metamagie", "", 2);
        public static WizardryTalentEnum ImprovedMagicWave = new WizardryTalentEnum(13, "Verbesserte Magische Welle", "", 2, ActionTypeEnum.Standard, MagicWave);
        public static WizardryTalentEnum SpellFocus2 = new WizardryTalentEnum(14, "Zauberfokus++", "", 2, SpellFocus);
        public static WizardryTalentEnum MagicPower2 = new WizardryTalentEnum(15, "Zaubermacht++", "", 2, MagicPower);
        public static WizardryTalentEnum Chronos = new WizardryTalentEnum(16, "Chronos", "", 3, ActionTypeEnum.Free);
        public static WizardryTalentEnum Dionysos = new WizardryTalentEnum(17, "Dionysos", "", 3, ActionTypeEnum.Standard);
        public static WizardryTalentEnum Thanos = new WizardryTalentEnum(18, "Thanos", "", 3, ActionTypeEnum.Standard);
        #endregion

        #region Konstruktor
        private WizardryTalentEnum(byte aID, string aName, string aDescription, int aTier)
            : base(aID, aName, aDescription, aTier, null, null) { }

        private WizardryTalentEnum(byte aID, string aName, string aDescription, int aTier, ActionTypeEnum? aActionType)
            : base(aID, aName, aDescription, aTier, aActionType, null) { }

        private WizardryTalentEnum(byte aID, string aName, string aDescription, int aTier, params WizardryTalentEnum[]? aPrerequisite)
            : base(aID, aName, aDescription, aTier, null, aPrerequisite) { }

        private WizardryTalentEnum(byte aID, string aName, string aDescription, int aTier, ActionTypeEnum? aActionType, params WizardryTalentEnum[]? aPrerequisite)
            : base(aID, aName, aDescription, aTier, aActionType, aPrerequisite) { }
        #endregion

        #region Methoden
        public static List<WizardryTalentEnum> Enumerate() {
            return Enumerations.EnumerationBase.Enumerate<WizardryTalentEnum>(DirectionEnum.ASC);
        }

        public static List<WizardryTalentEnum> Enumerate(DirectionEnum aDirection) {
            return Enumerations.EnumerationBase.Enumerate<WizardryTalentEnum>(aDirection);
        }

        public static int Count() {
            return Enumerations.EnumerationBase.Count<WizardryTalentEnum>();
        }

        public static WizardryTalentEnum Convert(int aID) {
            return Enumerations.EnumerationBase.Convert<WizardryTalentEnum>(aID, None);
        }

        public static WizardryTalentEnum Convert(string? aName) {
            return Enumerations.EnumerationBase.Convert<WizardryTalentEnum>(aName ?? string.Empty, None);
        }
        #endregion
    }
}