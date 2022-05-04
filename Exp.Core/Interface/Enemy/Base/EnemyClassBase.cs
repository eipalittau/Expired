namespace Exp.Data.Enemy {
    public abstract class EnemyClassBase : DataBase {
        #region Properties / Felder
        public int Initiative { get; set; }
        #endregion

        #region Konstruktor
        protected EnemyClassBase(string aID, int aSortWeight, int aInitiative)
            : base(aID, aSortWeight)
            => Initiative = aInitiative;
        #endregion
            
        #region Methoden
        protected void AddInstance() {
            Api.Enemy.EnemyClass.Singleton.Add(this);
        }
        #endregion
    }
}
