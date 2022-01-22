namespace RtD.Data {
    public class WonderTalentEnum : TalentEnumBase<WonderTalentEnum> {
        //TODO: Patrik: Klasse ist nur kopiert!
        #region Properties / Felder
        internal static WonderTalentEnum None = new WonderTalentEnum(0, nameof(None), string.Empty, 0);
        public static WonderTalentEnum BattleHardened = new WonderTalentEnum(1, "Kampferprobt", "", 1);
        public static WonderTalentEnum Stonethrower = new WonderTalentEnum(2, "Steinwerfer", "", 1, ActionTypeEnum.Standard);
        public static WonderTalentEnum EloquentInsulte = new WonderTalentEnum(3, "Eloquent beleidigen", "", 1, ActionTypeEnum.Standard);
        public static WonderTalentEnum PreciseShot = new WonderTalentEnum(4, "Präziser Schuss", "", 1);
        public static WonderTalentEnum SweepingBlow = new WonderTalentEnum(5, "Rundumschlag", "", 1, ActionTypeEnum.Standard);
        public static WonderTalentEnum Charge = new WonderTalentEnum(6, "CHARGE!", "", 1, ActionTypeEnum.Full);
        public static WonderTalentEnum Teamplayer = new WonderTalentEnum(7, "Teamplayer", "", 1);
        public static WonderTalentEnum TwoWeapons = new WonderTalentEnum(8, "Kampf mit zwei Waffen", "", 1);
        public static WonderTalentEnum StrongCharge = new WonderTalentEnum(9, "CHAAAARGE!!!", "", 2, ActionTypeEnum.Full);
        public static WonderTalentEnum Teamwork = new WonderTalentEnum(10, "Teamwork", "", 2, Teamplayer);
        public static WonderTalentEnum QuickMouth = new WonderTalentEnum(11, "Schnelles Mundwerk", "", 2, ActionTypeEnum.Move, EloquentInsulte);
        public static WonderTalentEnum Guileful = new WonderTalentEnum(12, "Hinterhältig", "", 2, ActionTypeEnum.Standard);
        public static WonderTalentEnum QuickShot = new WonderTalentEnum(13, "Schnellschuss", "", 2);
        public static WonderTalentEnum Anatomy = new WonderTalentEnum(14, "Anatomie", "", 2);
        public static WonderTalentEnum BetterTwoWeapons = new WonderTalentEnum(15, "Besserer Kampf mit zwei Waffen", "", 2, TwoWeapons);
        public static WonderTalentEnum Riposte = new WonderTalentEnum(16, "Riposte", "", 2);
        public static WonderTalentEnum ThornSkin = new WonderTalentEnum(17, "Dornenhaut", "", 2);
        public static WonderTalentEnum Cthulhu = new WonderTalentEnum(18, "Cthulhu", "", 3);
        public static WonderTalentEnum Chaos = new WonderTalentEnum(19, "Chaos", "", 3);
        public static WonderTalentEnum Hades = new WonderTalentEnum(20, "Hades", "", 3);
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
        //TODO: Patrik: Methoden umsetzen.
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