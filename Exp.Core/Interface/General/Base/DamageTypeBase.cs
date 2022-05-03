namespace Exp.Data.General {
    public abstract class DamageTypeBase : DataBase {
        #region Konstruktor
        protected DamageTypeBase(string aID, int aSortWeight)
            : base(aID, aSortWeight) { }
        #endregion
    }
}