namespace RtD.Data {
    //TODO: Patrik: Klasse ist nur kopiert!
    public class WizardryTalentEnum : TalentEnumBase<WizardryTalentEnum> {
        #region Properties / Felder
        internal static WizardryTalentEnum None = new WizardryTalentEnum(0, nameof(None), string.Empty, 0);
        public static WizardryTalentEnum BattleHardened = new WizardryTalentEnum(1, "Kampferprobt", "", 1);
        public static WizardryTalentEnum Stonethrower = new WizardryTalentEnum(2, "Steinwerfer", "", 1, ActionTypeEnum.Standard);
        public static WizardryTalentEnum EloquentInsulte = new WizardryTalentEnum(3, "Eloquent beleidigen", "", 1, ActionTypeEnum.Standard);
        public static WizardryTalentEnum PreciseShot = new WizardryTalentEnum(4, "Präziser Schuss", "", 1);
        public static WizardryTalentEnum SweepingBlow = new WizardryTalentEnum(5, "Rundumschlag", "", 1, ActionTypeEnum.Standard);
        public static WizardryTalentEnum Charge = new WizardryTalentEnum(6, "CHARGE!", "", 1, ActionTypeEnum.Full);
        public static WizardryTalentEnum Teamplayer = new WizardryTalentEnum(7, "Teamplayer", "", 1);
        public static WizardryTalentEnum TwoWeapons = new WizardryTalentEnum(8, "Kampf mit zwei Waffen", "", 1);
        public static WizardryTalentEnum StrongCharge = new WizardryTalentEnum(9, "CHAAAARGE!!!", "", 2, ActionTypeEnum.Full);
        public static WizardryTalentEnum Fireball = new WizardryTalentEnum(10, "Feuerball", "", 2);
        public static WizardryTalentEnum QuickMouth = new WizardryTalentEnum(11, "Schnelles Mundwerk", "", 2, ActionTypeEnum.Move, EloquentInsulte);
        public static WizardryTalentEnum Guileful = new WizardryTalentEnum(12, "Hinterhältig", "", 2, ActionTypeEnum.Standard);
        public static WizardryTalentEnum QuickShot = new WizardryTalentEnum(13, "Schnellschuss", "", 2);
        public static WizardryTalentEnum Anatomy = new WizardryTalentEnum(14, "Anatomie", "", 2);
        public static WizardryTalentEnum BetterTwoWeapons = new WizardryTalentEnum(15, "Besserer Kampf mit zwei Waffen", "", 2, TwoWeapons);
        public static WizardryTalentEnum Riposte = new WizardryTalentEnum(16, "Riposte", "", 2);
        public static WizardryTalentEnum ThornSkin = new WizardryTalentEnum(17, "Dornenhaut", "", 2);
        public static WizardryTalentEnum Cthulhu = new WizardryTalentEnum(18, "Cthulhu", "", 3);
        public static WizardryTalentEnum Chaos = new WizardryTalentEnum(19, "Chaos", "", 3);
        public static WizardryTalentEnum Hades = new WizardryTalentEnum(20, "Hades", "", 3);
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
        //TODO: Patrik: Methoden umsetzen.
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