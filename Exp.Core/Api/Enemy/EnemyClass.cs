namespace Exp.Api.Enemy {
    public sealed class EnemyClass : ApiBase<Data.Enemy.IEnemyClassData> {
        #region Properties / Felder
        public static EnemyClass Singleton { get; } = new();
        #endregion

        #region Konstruktor
        private EnemyClass() : base() { }
        #endregion
    }
}