namespace Exp.Api.Enemy {
    public sealed class EnemyClass : ApiBase<Data.Enemy.IEnemyClassData> {
        #region Properties / Felder
        public static EnemyClass Singleton { get; } = new();
        #endregion

        #region Konstruktor
        private EnemyClass() : base() { }
        #endregion

        #region Methoden
        public new void Remove(string aID) {
            base.Remove(aID);
        }

        public new void Clear() {
            base.Clear();
        }
        
        public new IList<Data.Enemy.IEnemyClassData> Enumerate() {
            return base.Enumerate();
        }

        public new Data.Enemy.IEnemyClassData Get(string aID) {
            return base.Get(aID);
        }

        public new int Count() {
            return base.Count();
        }

        public new void Add(Data.Enemy.IEnemyClassData aItem) {
            base.Add(aItem);
        }
        #endregion
    }
}