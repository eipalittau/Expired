namespace Exp.Data.General.DamageType {
    public abstract class DamageTypeBase : DataBase {
        #region Konstruktor
        protected DamageTypeBase(string aID, int aSortWeight)
            : base(aID, aSortWeight) { }
        #endregion

        #region Methoden
        protected static void AddInstance(IDamageTypeData aInstance) {
            Api.General.DamageType.Singleton.Add(aInstance);
        }
        #endregion
    }
}