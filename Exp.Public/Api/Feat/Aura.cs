using Exp.Data.Feat.Aura;

namespace Exp.Api.Feat {
    public sealed class Aura : ApiBase<IAuraData> {
        #region Properties / Felder
        public static Aura Singleton { get; } = new();
        #endregion

        #region Konstruktor
        private Aura() : base() { }
        #endregion

        #region Methoden
        public new void Remove(string aID) {
            base.Remove(aID);
        }

        public new void Clear() {
            base.Clear();
        }

        public new IList<IAuraData> Enumerate() {
            return base.Enumerate();
        }

        public new IAuraData Get(string aID) {
            return base.Get(aID);
        }

        public new IAuraData Get(int aIndex) {
            return base.Get(aIndex);
        }

        public new int Count() {
            return base.Count();
        }

        public new void Add(IAuraData aItem) {
            base.Add(aItem);
        }
        #endregion
    }
}