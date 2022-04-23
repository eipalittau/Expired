namespace RtD.Data {
    public class OffensiveTalentsEnum : TalentEnumBase<OffensiveTalentsEnum>, ITalent {
        #region Properties / Felder
        internal static OffensiveTalentsEnum None = new OffensiveTalentsEnum(0, nameof(None), string.Empty, 0);
        public static OffensiveTalentsEnum BattleHardened  = new OffensiveTalentsEnum(1, "Kampferprobt", "", 1);
        public static OffensiveTalentsEnum Stonethrower = new OffensiveTalentsEnum(2, "Steinwerfer", "", 1, ActionTypeEnum.Standard);
        public static OffensiveTalentsEnum EloquentInsulte = new OffensiveTalentsEnum(3, "Eloquent beleidigen", "", 1, ActionTypeEnum.Standard);
        public static OffensiveTalentsEnum PreciseShot = new OffensiveTalentsEnum(4, "Präziser Schuss", "", 1);
        public static OffensiveTalentsEnum SweepingBlow = new OffensiveTalentsEnum(5, "Rundumschlag", "", 1, ActionTypeEnum.Standard);
        public static OffensiveTalentsEnum Charge = new OffensiveTalentsEnum(6, "CHARGE!", "", 1, ActionTypeEnum.Full);
        public static OffensiveTalentsEnum Teamplayer = new OffensiveTalentsEnum(7, "Teamplayer", "", 1);
        public static OffensiveTalentsEnum TwoWeapons = new OffensiveTalentsEnum(8, "", "", 1);
        public static OffensiveTalentsEnum StrongCharge = new OffensiveTalentsEnum(9, "CHAAAARGE!!!", "", 2, ActionTypeEnum.Full);
        public static OffensiveTalentsEnum Teamwork = new OffensiveTalentsEnum(10, "Teamwork", "", 2, Teamplayer);
        public static OffensiveTalentsEnum QuickMouth = new OffensiveTalentsEnum(11, "Schnelles Mundwerk", "", 2, ActionTypeEnum.Move, EloquentInsulte);
        public static OffensiveTalentsEnum Guileful = new OffensiveTalentsEnum(12, "Hinterhältig", "", 2, ActionTypeEnum.Standard);
        public static OffensiveTalentsEnum QuickShot = new OffensiveTalentsEnum(13, "Schnellschuss", "", 2);
        public static OffensiveTalentsEnum Anatomy = new OffensiveTalentsEnum(14, "Anatomie", "", 2);
        public static OffensiveTalentsEnum BetterTwoWeapons = new OffensiveTalentsEnum(15, "Besserer Kampf mit zwei Waffen", "", 2, TwoWeapons);
        public static OffensiveTalentsEnum Riposte = new OffensiveTalentsEnum(16, "Riposte", "", 2);
        public static OffensiveTalentsEnum ThornSkin = new OffensiveTalentsEnum(17, "Dornenhaut", "", 2);
        public static OffensiveTalentsEnum Cthulhu = new OffensiveTalentsEnum(18, "Cthulhu", "", 3);
        public static OffensiveTalentsEnum Chaos = new OffensiveTalentsEnum(19, "Chaos", "", 3);
        public static OffensiveTalentsEnum Hades = new OffensiveTalentsEnum(20, "Hades", "", 3);
        #endregion

        #region Konstruktor
        private OffensiveTalentsEnum(byte aID, string aName, string aDescription, int aTier)
            : base(aID, aName, aDescription, aTier, null, null) { }

        private OffensiveTalentsEnum(byte aID, string aName, string aDescription, int aTier, ActionTypeEnum? aActionType)
            : base(aID, aName, aDescription, aTier, aActionType, null) { }

        private OffensiveTalentsEnum(byte aID, string aName, string aDescription, int aTier, params OffensiveTalentsEnum[]? aPrerequisite)
            : base(aID, aName, aDescription, aTier, null, aPrerequisite) { }

        private OffensiveTalentsEnum(byte aID, string aName, string aDescription, int aTier, ActionTypeEnum? aActionType, params OffensiveTalentsEnum[]? aPrerequisite)
            : base(aID, aName, aDescription, aTier, aActionType, aPrerequisite) { }
        #endregion

        #region Methoden
        public static List<OffensiveTalentsEnum> Enumerate() {
            return Enumerations.EnumerationBase.Enumerate<OffensiveTalentsEnum>(DirectionEnum.ASC);
        }

        public static List<OffensiveTalentsEnum> Enumerate(DirectionEnum aDirection) {
            return Enumerations.EnumerationBase.Enumerate<OffensiveTalentsEnum>(aDirection);
        }

        public static int Count() {
            return Enumerations.EnumerationBase.Count<OffensiveTalentsEnum>();
        }

        public static OffensiveTalentsEnum Convert(int aID) {
            return Enumerations.EnumerationBase.Convert<OffensiveTalentsEnum>(aID, None);
        }

        public static OffensiveTalentsEnum Convert(string? aName) {
            return Enumerations.EnumerationBase.Convert<OffensiveTalentsEnum>(aName ?? string.Empty, None);
        }
        #endregion
    }
}