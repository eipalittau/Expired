namespace Exp.Data.General {
    public abstract class ActionTypeBase : DataBase {
        #region Properties / Felder
        public double Weight { get; set; }
        #endregion

        #region Konstruktor
        protected ActionTypeBase(string aID, int aSortWeight, double aWeight)
            : base(aID, aSortWeight)
            => Weight = aWeight;
        #endregion
    }
}