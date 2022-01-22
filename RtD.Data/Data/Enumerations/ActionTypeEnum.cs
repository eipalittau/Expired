namespace RtD.Data {
    public class ActionTypeEnum : Enumerations.EnumerationBase {
        #region Properties / Felder
        internal static ActionTypeEnum None = new ActionTypeEnum(0, nameof(None), string.Empty, 0);
        public static ActionTypeEnum Free = new ActionTypeEnum(1, "Freie Aktion", "", 0);
        public static ActionTypeEnum Move = new ActionTypeEnum(2, "Bewegungsaktion", "", 1);
        public static ActionTypeEnum Standard = new ActionTypeEnum(3, "Standard Aktion", "",1.5);
        public static ActionTypeEnum Full = new ActionTypeEnum(4, "Volle Aktion", "", 2.5);

        public double Weight { get; }
        public double Limit { get; }
        #endregion

        #region Konstruktor
        private ActionTypeEnum(byte aID, string aName, string aDescription, double aWeight)
            : base(aID, aName, aDescription)
            => (Weight, Limit) = (aWeight, Full.Weight);
        #endregion
        //TODO: Patrik: Methoden umsetzen.
        #region Methoden
        public static List<ActionTypeEnum> Enumerate() {
            return Enumerations.EnumerationBase.Enumerate<ActionTypeEnum>(DirectionEnum.ASC);
        }

        public static List<ActionTypeEnum> Enumerate(DirectionEnum aDirection) {
            return Enumerations.EnumerationBase.Enumerate<ActionTypeEnum>(aDirection);
        }

        public static int Count() {
            return Enumerations.EnumerationBase.Count<ActionTypeEnum>();
        }

        public static ActionTypeEnum Convert(int aID) {
            return Enumerations.EnumerationBase.Convert<ActionTypeEnum>(aID, None);
        }

        public static ActionTypeEnum Convert(string? aName) {
            return Enumerations.EnumerationBase.Convert<ActionTypeEnum>(aName ?? string.Empty, None);
        }
        #endregion
    }
}