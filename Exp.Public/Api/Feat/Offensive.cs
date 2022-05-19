using Exp.Data.Feat.Offensive;

namespace Exp.Api.Feat {
    public sealed class Offensive : ApiBase<IOffensiveData> {
        #region Properties / Felder
        public static Offensive Singleton { get; } = new();
        #endregion

        #region Konstruktor
        private Offensive() : base() { }
        #endregion

        #region Methoden
        public new void Remove(string aID) {
            base.Remove(aID);
        }

        public new void Clear() {
            base.Clear();
        }

        public new IList<IOffensiveData> Enumerate() {
            return base.Enumerate();
        }

        public new IOffensiveData Get(string aID) {
            return base.Get(aID);
        }

        public new int Count() {
            return base.Count();
        }

        public new void Add(IOffensiveData aItem) {
            base.Add(aItem);
        }
        #endregion
    }
}