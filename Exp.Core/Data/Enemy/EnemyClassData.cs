namespace Exp.Data.Enemy {
    public sealed class EnemyClassData : DataBase {
        #region Properties / Felder
        public int Initiative { get; set; }
        #endregion

        #region Konstruktor
        internal EnemyClassData(int aID, string aName, string aDescription, uint aSortOrder, string aOrigin, int aInitiative)
            : base(aID, aName, aDescription, aSortOrder, aOrigin)
            => Initiative = aInitiative;
        #endregion
    }
}