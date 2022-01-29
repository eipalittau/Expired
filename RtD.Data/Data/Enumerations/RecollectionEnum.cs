namespace RtD.Data {
    /// <summary>Erinnerungen</summary>
    public class RecollectionEnum : Enumerations.EnumerationBase {
        #region Properties / Felder
        internal static RecollectionEnum None = new RecollectionEnum(0, nameof(None), string.Empty, 0, 0);
        public static RecollectionEnum Sharpening = new RecollectionEnum(1, "Ohrfeige erhalten", "", 1, 10);
        public static RecollectionEnum Hardening = new RecollectionEnum(2, "Geschubst worden", "", 11, 15);
        public static RecollectionEnum Refining = new RecollectionEnum(3, "Warum schlägst du dich selbst?", "", 16, 20);
        public static RecollectionEnum RaisePower = new RecollectionEnum(4, "Getränk verschüttet", "", 21, 25);
        public static RecollectionEnum CreateBoots = new RecollectionEnum(5, "Mentalist hat dich abgezockt", "", 26, 30);
        public static RecollectionEnum Upgrading = new RecollectionEnum(6, "Mentalist-\"Trank\"", "", 31, 35);
        public static RecollectionEnum InefficientSmithing = new RecollectionEnum(7, "Schmied beobachtet", "", 36, 40);
        public static RecollectionEnum EfficientSmithing = new RecollectionEnum(8, "Spanner", "", 41, 45);
        public static RecollectionEnum ElementalDamage = new RecollectionEnum(9, "In Loch gefallen", "", 45, 49);
        public static RecollectionEnum ElementalArmor = new RecollectionEnum(10, "Müll durchsucht", "", 50, 51);
        public static RecollectionEnum Enlarge = new RecollectionEnum(11, "Gestolpert", "", 52, 53);
        public static RecollectionEnum InefficientSmithing2 = new RecollectionEnum(12, "Schwer beleidigt worden", "", 54, 55);
        public static RecollectionEnum EfficientSmithing2 = new RecollectionEnum(13, "Haarewuscheln abgewehrt", "", 56, 58);
        public static RecollectionEnum Mastersmith = new RecollectionEnum(14, "Eins in die Fresse bekommen (verdienterweise)", "", 58, 59);
        public static RecollectionEnum WitchSmithy = new RecollectionEnum(15, "Faustschlag in die Magengrube bekommen", "", 60, 61);
        public static RecollectionEnum WitchSmithy = new RecollectionEnum(16, "Kugelstosskurs besucht", "", 60, 61);
        public static RecollectionEnum WitchSmithy = new RecollectionEnum(16, "", "", );
        public static RecollectionEnum WitchSmithy = new RecollectionEnum(16, "", "", );
        public static RecollectionEnum WitchSmithy = new RecollectionEnum(16, "", "", );
        public static RecollectionEnum WitchSmithy = new RecollectionEnum(16, "", "", );
        public static RecollectionEnum WitchSmithy = new RecollectionEnum(16, "", "", );
        public static RecollectionEnum WitchSmithy = new RecollectionEnum(16, "", "", );
        public static RecollectionEnum WitchSmithy = new RecollectionEnum(16, "", "", );
        public static RecollectionEnum WitchSmithy = new RecollectionEnum(16, "", "", );
        public static RecollectionEnum WitchSmithy = new RecollectionEnum(16, "", "", );
        public static RecollectionEnum WitchSmithy = new RecollectionEnum(16, "", "", );
        public static RecollectionEnum WitchSmithy = new RecollectionEnum(16, "", "", );
        public static RecollectionEnum WitchSmithy = new RecollectionEnum(16, "", "", );
        public static RecollectionEnum WitchSmithy = new RecollectionEnum(16, "", "", );
        public static RecollectionEnum WitchSmithy = new RecollectionEnum(16, "", "", );
        public static RecollectionEnum WitchSmithy = new RecollectionEnum(16, "", "", );
        public static RecollectionEnum WitchSmithy = new RecollectionEnum(16, "", "", );
        public static RecollectionEnum WitchSmithy = new RecollectionEnum(16, "", "", );
        public static RecollectionEnum WitchSmithy = new RecollectionEnum(16, "", "", );
        public static RecollectionEnum WitchSmithy = new RecollectionEnum(16, "", "", );
        public static RecollectionEnum WitchSmithy = new RecollectionEnum(16, "", "", );
        public static RecollectionEnum WitchSmithy = new RecollectionEnum(16, "", "", );
        public static RecollectionEnum WitchSmithy = new RecollectionEnum(16, "", "", );
        public static RecollectionEnum WitchSmithy = new RecollectionEnum(16, "", "", );
        public static RecollectionEnum WitchSmithy = new RecollectionEnum(16, "", "", );
        public static RecollectionEnum WitchSmithy = new RecollectionEnum(16, "", "", );
        public static RecollectionEnum WitchSmithy = new RecollectionEnum(16, "", "", );
        public static RecollectionEnum WitchSmithy = new RecollectionEnum(16, "", "", );
        public static RecollectionEnum WitchSmithy = new RecollectionEnum(16, "", "", );

        public int DiceStart { get; }
        public int DiceEnd { get; }
        #endregion

        #region Konstruktor
        private RecollectionEnum(byte aID, string aName, string aDescription, int aDiceStart, int aDiceEnd)
            : base(aID, aName, aDescription) {
            DiceStart = aDiceStart;
            DiceEnd = aDiceEnd;
        }
        #endregion

        #region Methoden
        public static List<RecollectionEnum> Enumerate() {
            return Enumerations.EnumerationBase.Enumerate<RecollectionEnum>(DirectionEnum.ASC);
        }

        public static List<RecollectionEnum> Enumerate(DirectionEnum aDirection) {
            return Enumerations.EnumerationBase.Enumerate<RecollectionEnum>(aDirection);
        }

        public static int Count() {
            return Enumerations.EnumerationBase.Count<RecollectionEnum>();
        }

        public static RecollectionEnum Convert(int aID) {
            return Enumerations.EnumerationBase.Convert<RecollectionEnum>(aID, None);
        }

        public static RecollectionEnum Convert(string? aName) {
            return Enumerations.EnumerationBase.Convert<RecollectionEnum>(aName ?? string.Empty, None);
        }
        #endregion
    }
}