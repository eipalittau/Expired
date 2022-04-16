namespace Exp.Data.Enemy {
    public sealed class EnemyClassData : DataBase {
        #region Properties / Felder
        public int Initiative { get; set; }
        #endregion

        #region Konstruktor
        internal EnemyClassData(string aID, int aSortWeight, string aOrigin, int aInitiative)
            : base(aID, string.Empty, string.Empty, aSortWeight, aOrigin)
            => Initiative = aInitiative;
        #endregion
    }
}