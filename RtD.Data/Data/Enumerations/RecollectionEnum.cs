namespace RtD.Data {
    /// <summary>Erinnerungen</summary>
    /// 

    public class RecollectionEnum : Enumerations.EnumerationBase {
        #region Properties / Felder
        internal static RecollectionEnum None = new RecollectionEnum(0, nameof(None), string.Empty, 0, 0);
        public static RecollectionEnum Recollection1 = new RecollectionEnum(1, "Ohrfeige erhalten", "", 1, 10);
        public static RecollectionEnum Recollection2 = new RecollectionEnum(2, "Geschubst worden", "", 11, 15);
        public static RecollectionEnum Recollection3 = new RecollectionEnum(3, "Warum schlägst du dich selbst?", "", 16, 20);
        public static RecollectionEnum Recollection4 = new RecollectionEnum(4, "Getränk verschüttet", "", 21, 25);
        public static RecollectionEnum Recollection5 = new RecollectionEnum(5, "Mentalist hat dich abgezockt", "", 26, 30);
        public static RecollectionEnum Recollection6 = new RecollectionEnum(6, "Mentalist-\"Trank\"", "", 31, 35);
        public static RecollectionEnum Recollection7 = new RecollectionEnum(7, "Schmied beobachtet", "", 36, 40);
        public static RecollectionEnum Recollection8 = new RecollectionEnum(8, "Spanner", "", 41, 45);
        public static RecollectionEnum Recollection9 = new RecollectionEnum(9, "In Loch gefallen", "", 45, 49);
        public static RecollectionEnum Recollection10 = new RecollectionEnum(10, "Müll durchsucht", "", 50, 51);
        public static RecollectionEnum Recollection11 = new RecollectionEnum(11, "Gestolpert", "", 52, 53);
        public static RecollectionEnum Recollection12 = new RecollectionEnum(12, "Schwer beleidigt worden", "", 54, 55);
        public static RecollectionEnum Recollection13 = new RecollectionEnum(13, "Haarewuscheln abgewehrt", "", 56, 58);
        public static RecollectionEnum Recollection14 = new RecollectionEnum(14, "Eins in die Fresse bekommen (verdienterweise)", "", 58, 59);
        public static RecollectionEnum Recollection15 = new RecollectionEnum(15, "Faustschlag in die Magengrube bekommen", "", 60, 61);
        public static RecollectionEnum Recollection16 = new RecollectionEnum(16, "Kugelstosskurs besucht", "", 63, 64);
        public static RecollectionEnum Recollection17 = new RecollectionEnum(17, "Historisches Buch gelesen", "", 65, 66);
        public static RecollectionEnum Recollection18 = new RecollectionEnum(18, "Geheime Kugelstosstechnik", "", 67, 68);
        public static RecollectionEnum Recollection19 = new RecollectionEnum(19, "Am finger ziehen, war magisch", "", 69, 70);
        public static RecollectionEnum Recollection20 = new RecollectionEnum(20, "Kinderbuch gelesen", "", 71, 72);
        public static RecollectionEnum Recollection21 = new RecollectionEnum(21, "2 Ohrfeigen gleichzeitig erhalten", "", 73, 74);
        public static RecollectionEnum Recollection22 = new RecollectionEnum(22, "Finger gequetscht", "", 75, 76);
        public static RecollectionEnum Recollection23 = new RecollectionEnum(23, "Kugelstosswettbewerb 4.", "", 77, 78);
        public static RecollectionEnum Recollection24 = new RecollectionEnum(24, "Pantomimenkurs", "", 79, 80);
        public static RecollectionEnum Recollection25 = new RecollectionEnum(25, "Hat mal was vergessen", "", 81, 82);
        public static RecollectionEnum Recollection26 = new RecollectionEnum(26, "Einen toten beklaut", "", 83, 84);
        public static RecollectionEnum Recollection27 = new RecollectionEnum(27, "1000 years of pain", "", 84, 86);
        public static RecollectionEnum Recollection28 = new RecollectionEnum(28, "3 Tage schlaflos", "", 87, 88);
        public static RecollectionEnum Recollection29 = new RecollectionEnum(29, "Talentschau", "", 89, 90);
        public static RecollectionEnum Recollection30 = new RecollectionEnum(30, "Zehen gestossen", "", 90, 90);
        public static RecollectionEnum Recollection31 = new RecollectionEnum(31, "Talentschau", "", 91, 91);
        public static RecollectionEnum Recollection32 = new RecollectionEnum(32, "Notizblock verloren", "", 92, 92);
        public static RecollectionEnum Recollection33 = new RecollectionEnum(33, "Zugeschaut bei fähigen Kämpfern", "", 93, 93);
        public static RecollectionEnum Recollection34 = new RecollectionEnum(34, "In einer Schlägerei verprügelt worden", "", 94, 94);
        public static RecollectionEnum Recollection35 = new RecollectionEnum(35, "Eine Stunde mit einem Mentalisten geschwatzt", "", 95, 95);
        public static RecollectionEnum Recollection36 = new RecollectionEnum(36, "Eine Stunde mit einem Priester geschwatzt", "", 96, 96);
        public static RecollectionEnum Recollection37 = new RecollectionEnum(37, "Ein Jahr im Kloster verbracht", "", 97, 97);
        public static RecollectionEnum Recollection38 = new RecollectionEnum(38, "- Frei erzählen -", "", 98, 98);
        public static RecollectionEnum Recollection39 = new RecollectionEnum(39, "Kalender verloren", "", 99, 99);
        public static RecollectionEnum Recollection40 = new RecollectionEnum(40, "Geistesblitz", "", 100, 100);
        public static RecollectionEnum Recollection41 = new RecollectionEnum(41, "Jemand hat mal gesagt du bist cool", "", 100, int.MaxValue);


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

        public static bool IsBetween(int aValue) {
            return Get(aValue) != null;
        }

        public static RecollectionEnum? Get(int aValue) {
            RecollectionEnum? lResult = RecollectionEnum.Enumerate()
                .Where(x => x.GetType().IsPublic)
                .Where(x => aValue >= x.DiceStart)
                .Where(x => aValue <= x.DiceEnd)
                .FirstOrDefault();

            if (lResult == null) {
                return null;
            } else {
                return lResult;
            }
        }
        #endregion
    }
}