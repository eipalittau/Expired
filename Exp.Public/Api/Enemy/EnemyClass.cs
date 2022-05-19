using Exp.Data.Enemy.EnemyClass;

namespace Exp.Api.Enemy {
    public sealed class EnemyClass : ApiBase<IEnemyClassData> {
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
        
        public new IList<IEnemyClassData> Enumerate() {
            return base.Enumerate();
        }

        public new IEnemyClassData Get(string aID) {
            return base.Get(aID);
        }

        public new int Count() {
            return base.Count();
        }

        public new void Add(IEnemyClassData aItem) {
            base.Add(aItem);
        }
        #endregion
    }
}