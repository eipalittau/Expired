namespace Exp.DefaultMod.General {
    public abstract class DamageTypeBase : DataBase, Data.General.IDamageTypeDataBase {
        #region Konstruktor
        private protected DamageTypeBase(string aID, int aSortWeight)
            : base(aID, aSortWeight) { }
        #endregion
    }
}