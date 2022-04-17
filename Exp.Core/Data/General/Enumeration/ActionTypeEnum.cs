namespace Exp.Data.General {
    public sealed class ActionTypeEnum : Util.EnumerationBase {
        #region Properties / Felder
        #region Static
        internal static ActionTypeEnum None = new(0, 0);
        public static ActionTypeEnum Free = new(1, 0); // Freie Aktion
        public static ActionTypeEnum Move = new(2, 1); // Bewegungsaktion
        public static ActionTypeEnum Standard = new(3, 1.5); // Standard Aktion
        public static ActionTypeEnum Full = new(4, 2.5); // Volle Aktion
        #endregion

        #region Instance
        public double Weight { get; }
        public double Limit { get; }
        #endregion
        #endregion

        #region Konstruktor
        private ActionTypeEnum(int aID, double aWeight)
            : base(aID, string.Empty, string.Empty)
            => (Weight, Limit) = (aWeight, Full.Weight);
        #endregion

        #region Methoden
        public static IList<ActionTypeEnum> Enumerate() {
            return Util.EnumerationBase.Enumerate<ActionTypeEnum>(DirectionEnum.ASC);
        }

        public static int Count() {
            return Util.EnumerationBase.Count<ActionTypeEnum>();
        }

        public static ActionTypeEnum Convert(int aID) {
            return Util.EnumerationBase.Convert(aID, None);
        }

        public static ActionTypeEnum Convert(string aName) {
            return Util.EnumerationBase.Convert(aName, None);
        }
        #endregion
    }
}