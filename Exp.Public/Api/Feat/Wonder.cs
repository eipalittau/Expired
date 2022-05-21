using Exp.Data.Feat.Wonder;

namespace Exp.Api.Feat {
    public sealed class Wonder : ApiBase<IWonderData> {
        #region Properties / Felder
        public static Wonder Singleton { get; } = new();
        #endregion

        #region Konstruktor
        private Wonder() : base() { }
        #endregion

        #region Methoden
        public new void Remove(string aID) {
            base.Remove(aID);
        }

        public new void Clear() {
            base.Clear();
        }

        public new IList<IWonderData> Enumerate() {
            return base.Enumerate();
        }

        public new IWonderData Get(string aID) {
            return base.Get(aID);
        }

        public new IWonderData Get(int aIndex) {
            return base.Get(aIndex);
        }

        public new int Count() {
            return base.Count();
        }

        public new void Add(IWonderData aItem) {
            base.Add(aItem);
        }
        #endregion
    }
}