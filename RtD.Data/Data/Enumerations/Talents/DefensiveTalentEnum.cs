namespace RtD.Data {
    public class DefensiveTalentEnum : TalentEnumBase<DefensiveTalentEnum>, ITalent {
        #region Properties / Felder
        internal static DefensiveTalentEnum None = new DefensiveTalentEnum(0, nameof(None), string.Empty, 0);
        public static DefensiveTalentEnum Jostle = new DefensiveTalentEnum(1, "Schubsen", "", 1, ActionTypeEnum.Free);
        public static DefensiveTalentEnum Tough = new DefensiveTalentEnum(2, "Zäh", "", 1);
        public static DefensiveTalentEnum FelineReflex = new DefensiveTalentEnum(3, "Katzenreflex", "", 1);
        public static DefensiveTalentEnum DangerInstinct  = new DefensiveTalentEnum(4, "Gefahreninstinkt", "", 1);
        public static DefensiveTalentEnum Dodge = new DefensiveTalentEnum(5, "Ausweichen", "", 1);
        public static DefensiveTalentEnum Agile = new DefensiveTalentEnum(6, "Agil", "", 1);
        public static DefensiveTalentEnum Teamplayer = new DefensiveTalentEnum(7, "Teamplayer", "", 1);
        public static DefensiveTalentEnum Pindown = new DefensiveTalentEnum(8, "Anpinnen", "", 1);
        public static DefensiveTalentEnum Shadowy = new DefensiveTalentEnum(9, "Schattenhaft", "", 2);
        public static DefensiveTalentEnum SecondWind  = new DefensiveTalentEnum(10, "Zweiter Wind", "", 2, ActionTypeEnum.Standard);
        public static DefensiveTalentEnum Teamwork = new DefensiveTalentEnum(11, "Teamwork", "", 2, Teamplayer);
        public static DefensiveTalentEnum StoneSkin = new DefensiveTalentEnum(12, "Steinhaut", "", 2);
        public static DefensiveTalentEnum ImprovedDodge = new DefensiveTalentEnum(13, "Verbessertes Ausweichen", "", 2, Dodge);
        public static DefensiveTalentEnum PussInBoots  = new DefensiveTalentEnum(14, "Der gestiefelte Kater", "", 2);
        public static DefensiveTalentEnum RoadRunner = new DefensiveTalentEnum(15, "RoadRunner", "", 2);
        public static DefensiveTalentEnum Hermes = new DefensiveTalentEnum(16, "Hermes", "", 3);
        public static DefensiveTalentEnum Hephaistos = new DefensiveTalentEnum(17, "Hephaistos", "", 3);
        public static DefensiveTalentEnum Zeus = new DefensiveTalentEnum(18, "Zeus", "", 3);
        #endregion

        #region Konstruktor
        private DefensiveTalentEnum(byte aID, string aName, string aDescription, int aTier)
            : base(aID, aName, aDescription, aTier, null, null) { }

        private DefensiveTalentEnum(byte aID, string aName, string aDescription, int aTier, ActionTypeEnum? aActionType)
            : base(aID, aName, aDescription, aTier, aActionType, null) { }

        private DefensiveTalentEnum(byte aID, string aName, string aDescription, int aTier, params DefensiveTalentEnum[]? aPrerequisite)
            : base(aID, aName, aDescription, aTier, null, aPrerequisite) { }
        #endregion

        #region Methoden
        public static List<DefensiveTalentEnum> Enumerate() {
            return Enumerations.EnumerationBase.Enumerate<DefensiveTalentEnum>(DirectionEnum.ASC);
        }

        public static List<DefensiveTalentEnum> Enumerate(DirectionEnum aDirection) {
            return Enumerations.EnumerationBase.Enumerate<DefensiveTalentEnum>(aDirection);
        }

        public static int Count() {
            return Enumerations.EnumerationBase.Count<DefensiveTalentEnum>();
        }

        public static DefensiveTalentEnum Convert(int aID) {
            return Enumerations.EnumerationBase.Convert<DefensiveTalentEnum>(aID, None);
        }

        public static DefensiveTalentEnum Convert(string? aName) {
            return Enumerations.EnumerationBase.Convert<DefensiveTalentEnum>(aName ?? string.Empty, None);
        }
        #endregion
    }
}