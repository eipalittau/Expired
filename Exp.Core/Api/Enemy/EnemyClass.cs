namespace Exp.Api.Enemy {
    public sealed class EnemyClass : ApiBase<Data.Enemy.EnemyClassData> {
        #region Properties / Felder
        private static readonly EnemyClass mSingleton = new();
        #endregion

        #region Konstruktor
        internal EnemyClass() : base() {
            Add("Kämpfer", 400, 400);
        }
        #endregion

        #region Methoden
        public static EnemyClass Singleton {
            get {
                return mSingleton;
            }
        }

        public void Add(string aID, int aInitiative, int aSortWeight = 0) {
            base.Add(new Data.Enemy.EnemyClassData(aID, aInitiative, aSortWeight));
        }
        #endregion
    }
}