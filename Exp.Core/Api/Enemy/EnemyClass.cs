namespace Exp.Api.Enemy {
    public sealed class EnemyClass : ApiBase<Data.Enemy.EnemyClassData> {
        #region Properties / Felder
        private static readonly EnemyClass mSingleton = new();
        #endregion

        #region Konstruktor
        internal EnemyClass() : base() {
            Add("Kämpfer", 400, string.Empty, 400);
        }
        #endregion

        #region Methoden
        public static EnemyClass Singleton
        {
            get
            {
                return mSingleton;
            }
        }

        public void Add(string aID, int aInitiative) {
            Add(aID, base.Count() + 1, aInitiative);
        }

        public void Add(string aID, int aSortWeight, int aInitiative) {
            Add(aID, aSortWeight, base.GetOriginNameCaller(), aInitiative);
        }

        private void Add(string aID, int aSortWeight, string aOrigin, int aInitiative) {
            base.Add(new Data.Enemy.EnemyClassData(aID, aSortWeight, aOrigin, aInitiative));
        }
        #endregion
    }
}