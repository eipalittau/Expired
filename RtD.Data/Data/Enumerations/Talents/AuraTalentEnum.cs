namespace RtD.Data {
    public class AuraTalentEnum : TalentEnumBase<AuraTalentEnum> {
        //Patrik: Klasse ist nur kopiert!
        #region Properties / Felder
        internal static AuraTalentEnum None = new AuraTalentEnum(0, nameof(None), string.Empty, 0);
        public static AuraTalentEnum BattleHardened = new AuraTalentEnum(1, "Kampferprobt", "", 1);
        public static AuraTalentEnum Stonethrower = new AuraTalentEnum(2, "Steinwerfer", "", 1, ActionTypeEnum.Standard);
        public static AuraTalentEnum EloquentInsulte = new AuraTalentEnum(3, "Eloquent beleidigen", "", 1, ActionTypeEnum.Standard);
        public static AuraTalentEnum PreciseShot = new AuraTalentEnum(4, "Präziser Schuss", "", 1);
        public static AuraTalentEnum SweepingBlow = new AuraTalentEnum(5, "Rundumschlag", "", 1, ActionTypeEnum.Standard);
        public static AuraTalentEnum Charge = new AuraTalentEnum(6, "CHARGE!", "", 1, ActionTypeEnum.Full);
        public static AuraTalentEnum Teamplayer = new AuraTalentEnum(7, "Teamplayer", "", 1);
        public static AuraTalentEnum TwoWeapons = new AuraTalentEnum(8, "Kampf mit zwei Waffen", "", 1);
        public static AuraTalentEnum StrongCharge = new AuraTalentEnum(9, "CHAAAARGE!!!", "", 2, ActionTypeEnum.Full);
        public static AuraTalentEnum Teamwork = new AuraTalentEnum(10, "Teamwork", "", 2, Teamplayer);
        public static AuraTalentEnum QuickMouth = new AuraTalentEnum(11, "Schnelles Mundwerk", "", 2, ActionTypeEnum.Move, EloquentInsulte);
        public static AuraTalentEnum Guileful = new AuraTalentEnum(12, "Hinterhältig", "", 2, ActionTypeEnum.Standard);
        public static AuraTalentEnum QuickShot = new AuraTalentEnum(13, "Schnellschuss", "", 2);
        public static AuraTalentEnum Anatomy = new AuraTalentEnum(14, "Anatomie", "", 2);
        public static AuraTalentEnum BetterTwoWeapons = new AuraTalentEnum(15, "Besserer Kampf mit zwei Waffen", "", 2, TwoWeapons);
        public static AuraTalentEnum Riposte = new AuraTalentEnum(16, "Riposte", "", 2);
        public static AuraTalentEnum ThornSkin = new AuraTalentEnum(17, "Dornenhaut", "", 2);
        public static AuraTalentEnum Cthulhu = new AuraTalentEnum(18, "Cthulhu", "", 3);
        public static AuraTalentEnum Chaos = new AuraTalentEnum(19, "Chaos", "", 3);
        public static AuraTalentEnum Hades = new AuraTalentEnum(20, "Hades", "", 3);
        #endregion

        #region Konstruktor
        private AuraTalentEnum(byte aID, string aName, string aDescription, int aTier)
            : base(aID, aName, aDescription, aTier, null, null) { }

        private AuraTalentEnum(byte aID, string aName, string aDescription, int aTier, ActionTypeEnum? aActionType)
            : base(aID, aName, aDescription, aTier, aActionType, null) { }

        private AuraTalentEnum(byte aID, string aName, string aDescription, int aTier, params AuraTalentEnum[]? aPrerequisite)
            : base(aID, aName, aDescription, aTier, null, aPrerequisite) { }

        private AuraTalentEnum(byte aID, string aName, string aDescription, int aTier, ActionTypeEnum? aActionType, params AuraTalentEnum[]? aPrerequisite)
            : base(aID, aName, aDescription, aTier, aActionType, aPrerequisite) { }
        #endregion

        #region Methoden
        public static List<AuraTalentEnum> Enumerate() {
            return Enumerations.EnumerationBase.Enumerate<AuraTalentEnum>(DirectionEnum.ASC);
        }

        public static List<AuraTalentEnum> Enumerate(DirectionEnum aDirection) {
            return Enumerations.EnumerationBase.Enumerate<AuraTalentEnum>(aDirection);
        }

        public static int Count() {
            return Enumerations.EnumerationBase.Count<AuraTalentEnum>();
        }

        public static AuraTalentEnum Convert(int aID) {
            return Enumerations.EnumerationBase.Convert<AuraTalentEnum>(aID, None);
        }

        public static AuraTalentEnum Convert(string? aName) {
            return Enumerations.EnumerationBase.Convert<AuraTalentEnum>(aName ?? string.Empty, None);
        }
        #endregion
    }
}