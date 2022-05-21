using Exp.Data.Feat.Defensive;

namespace Exp.Api.Feat {
    public sealed class Defensive : ApiBase<IDefensiveData> {
        #region Properties / Felder
        public static Defensive Singleton { get; } = new();
        #endregion

        #region Konstruktor
        internal Defensive() : base() { }
        #endregion

        #region Methoden
        public new void Remove(string aID) {
            base.Remove(aID);
        }

        public new void Clear() {
            base.Clear();
        }

        public new IList<IDefensiveData> Enumerate() {
            return base.Enumerate();
        }

        public new IDefensiveData Get(string aID) {
            return base.Get(aID);
        }

        public new IDefensiveData Get(int aIndex) {
            return base.Get(aIndex);
        }

        public new int Count() {
            return base.Count();
        }

        public new void Add(IDefensiveData aItem) {
            base.Add(aItem);
        }
        #endregion
    }
}