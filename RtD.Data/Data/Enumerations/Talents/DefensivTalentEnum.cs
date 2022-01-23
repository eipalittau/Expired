namespace RtD.Data {
    public class DefensivTalentEnum : TalentEnumBase<DefensivTalentEnum> {
        #region Properties / Felder
        internal static DefensivTalentEnum None = new DefensivTalentEnum(0, nameof(None), string.Empty, 0);
        public static DefensivTalentEnum Jostle = new DefensivTalentEnum(1, "Schubsen", "", 1, ActionTypeEnum.Free);
        public static DefensivTalentEnum Tough = new DefensivTalentEnum(2, "Zäh", "", 1);
        public static DefensivTalentEnum FelineReflex = new DefensivTalentEnum(3, "Katzenreflex", "", 1);
        public static DefensivTalentEnum DangerInstinct  = new DefensivTalentEnum(4, "Gefahreninstinkt", "", 1);
        public static DefensivTalentEnum Dodge = new DefensivTalentEnum(5, "Ausweichen", "", 1);
        public static DefensivTalentEnum Agile = new DefensivTalentEnum(6, "Agil", "", 1);
        public static DefensivTalentEnum Teamplayer = new DefensivTalentEnum(7, "Teamplayer", "", 1);
        public static DefensivTalentEnum Pindown = new DefensivTalentEnum(8, "Anpinnen", "", 1);
        public static DefensivTalentEnum Shadowy = new DefensivTalentEnum(9, "Schattenhaft", "", 2);
        public static DefensivTalentEnum SecondWind  = new DefensivTalentEnum(10, "Zweiter Wind", "", 2);
        public static DefensivTalentEnum Teamwork = new DefensivTalentEnum(11, "Teamwork", "", 2, Teamplayer);
        public static DefensivTalentEnum StoneSkin = new DefensivTalentEnum(12, "Steinhaut", "", 2);
        public static DefensivTalentEnum ImprovedDodge = new DefensivTalentEnum(13, "Verbessertes Ausweichen", "", 2, Dodge);
        public static DefensivTalentEnum PussInBoots  = new DefensivTalentEnum(14, "Der gestiefelte Kater", "", 2);
        public static DefensivTalentEnum RoadRunner = new DefensivTalentEnum(15, "RoadRunner", "", 2);
        public static DefensivTalentEnum Hermes = new DefensivTalentEnum(16, "Hermes", "", 3);
        public static DefensivTalentEnum Hephaistos = new DefensivTalentEnum(17, "Hephaistos", "", 3);
        public static DefensivTalentEnum Zeus = new DefensivTalentEnum(18, "Zeus", "", 3);
        #endregion

        #region Konstruktor
        private DefensivTalentEnum(byte aID, string aName, string aDescription, int aTier)
            : base(aID, aName, aDescription, aTier, null, null) { }

        private DefensivTalentEnum(byte aID, string aName, string aDescription, int aTier, ActionTypeEnum? aActionType)
            : base(aID, aName, aDescription, aTier, aActionType, null) { }

        private DefensivTalentEnum(byte aID, string aName, string aDescription, int aTier, params DefensivTalentEnum[]? aPrerequisite)
            : base(aID, aName, aDescription, aTier, null, aPrerequisite) { }
        #endregion

        #region Methoden
        public static List<DefensivTalentEnum> Enumerate() {
            return Enumerations.EnumerationBase.Enumerate<DefensivTalentEnum>(DirectionEnum.ASC);
        }

        public static List<DefensivTalentEnum> Enumerate(DirectionEnum aDirection) {
            return Enumerations.EnumerationBase.Enumerate<DefensivTalentEnum>(aDirection);
        }

        public static int Count() {
            return Enumerations.EnumerationBase.Count<DefensivTalentEnum>();
        }

        public static DefensivTalentEnum Convert(int aID) {
            return Enumerations.EnumerationBase.Convert<DefensivTalentEnum>(aID, None);
        }

        public static DefensivTalentEnum Convert(string? aName) {
            return Enumerations.EnumerationBase.Convert<DefensivTalentEnum>(aName ?? string.Empty, None);
        }
        #endregion
    }
}