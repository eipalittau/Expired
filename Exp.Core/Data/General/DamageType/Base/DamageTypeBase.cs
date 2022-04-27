namespace Exp.Data.General {
    public abstract class DamageTypeBase : DataBase, IDamageTypeDataBase {
        #region Konstruktor
        private protected DamageTypeBase(string aID, int aSortWeight)
            : base(aID, aSortWeight) { }
        #endregion
    }
}