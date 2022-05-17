namespace Exp.Data.General.ActionType {
    public abstract class ActionTypeBase : DataBase {
        #region Properties / Felder
        public double Weight { get; set; }
        #endregion

        #region Konstruktor
        protected ActionTypeBase(string aID, int aSortWeight, double aWeight)
            : base(aID, aSortWeight)
            => Weight = aWeight;
        #endregion

        #region Methoden
        protected static void AddInstance(IActionTypeData aInstance) {
            Api.General.ActionType.Singleton.Add(aInstance);
        }
        #endregion
    }
}