namespace RtD.Data {
    public class AuraTalentEnum : TalentEnumBase<AuraTalentEnum> {

        #region Properties / Felder
        internal static AuraTalentEnum None = new AuraTalentEnum(0, nameof(None), string.Empty, 0);
        public static AuraTalentEnum Fencer = new AuraTalentEnum(1, "Aura des Fechters", "", 1);
        public static AuraTalentEnum Power = new AuraTalentEnum(2, "Aura der Macht", "", 1);
        public static AuraTalentEnum Defense = new AuraTalentEnum(3, "Aura der Verteidigung", "", 1);
        public static AuraTalentEnum Reflexes = new AuraTalentEnum(4, "Aura der Reflexe", "", 1);
        public static AuraTalentEnum Will = new AuraTalentEnum(5, "Aura des Willens", "", 1);
        public static AuraTalentEnum Anger = new AuraTalentEnum(6, "Aura des Zorns", "", 1, Fencer, Power);
        public static AuraTalentEnum Focus = new AuraTalentEnum(7, "Fokus", "", 1);
        public static AuraTalentEnum EnhancedAura = new AuraTalentEnum(8, "Verstärkte Aura", "", 1);
        public static AuraTalentEnum Flatulence = new AuraTalentEnum(9, "Blähungen", "", 1);
        public static AuraTalentEnum BrokenWingsGambit = new AuraTalentEnum(10, "Gambit der gebrochenen Flügel", "", 1, ActionTypeEnum.Free);
        public static AuraTalentEnum Agile = new AuraTalentEnum(11, "Geschickt", "", 1);
        public static AuraTalentEnum Coordinated = new AuraTalentEnum(12, "Koordiniert", "", 1);
        public static AuraTalentEnum LoveAndPieces = new AuraTalentEnum(13, "Love and Pieces", "", 1, ActionTypeEnum.Move);
        public static AuraTalentEnum Sadist = new AuraTalentEnum(14, "Sadist", "", 1);
        public static AuraTalentEnum Masochist = new AuraTalentEnum(15, "Masochist", "", 1);
        public static AuraTalentEnum Perfection = new AuraTalentEnum(16, "Perfektion", "", 2);
        public static AuraTalentEnum Interdisciplinary = new AuraTalentEnum(17, "Interdisziplinär", "", 2);
        public static AuraTalentEnum BannerBearer = new AuraTalentEnum(18, "Bannerträger", "", 2);
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