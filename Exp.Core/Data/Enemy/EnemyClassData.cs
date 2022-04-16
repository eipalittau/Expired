namespace Exp.Data.Enemy {
    public sealed class EnemyClassData : DataBase {
        #region Properties / Felder
        public int Initiative { get; set; }
        #endregion

        #region Konstruktor
        internal EnemyClassData(string aID, int aInitiative, int aSortWeight = 0)
            : base(aID, aSortWeight)
            => Initiative = aInitiative;
        #endregion
    }
}