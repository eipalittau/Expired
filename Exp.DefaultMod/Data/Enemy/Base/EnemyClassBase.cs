namespace Exp.DefaultMod.Enemy {
    internal abstract class EnemyClassBase : DataBase, Data.Enemy.IEnemyClassDataBase {
        #region Properties / Felder
        public int Initiative { get; set; }
        #endregion

        #region Konstruktor
        private protected EnemyClassBase(string aID, int aSortWeight, int aInitiative)
            : base(aID, aSortWeight)
            => Initiative = aInitiative;
        #endregion
    }
}
