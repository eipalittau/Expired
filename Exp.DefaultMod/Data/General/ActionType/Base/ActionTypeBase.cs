namespace Exp.DefaultMod.General {
    public abstract class ActionTypeBase : DataBase, Data.General.IActionTypeDataBase {
        #region Properties / Felder
        public double Weight { get; set; }
        #endregion

        #region Konstruktor
        private protected ActionTypeBase(string aID, int aSortWeight, double aWeight)
            : base(aID, aSortWeight)
            => Weight = aWeight;
        #endregion
    }
}