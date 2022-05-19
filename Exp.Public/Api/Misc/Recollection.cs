using Exp.Data.Misc.Recollection;

namespace Exp.Api.Misc {
    public sealed class Recollection : ApiBase<IRecollectionData> {
        #region Properties / Felder
        public static Recollection Singleton { get; } = new();
        #endregion

        #region Konstruktor
        private Recollection() : base() { }
        #endregion

        #region Methoden
        public new void Remove(string aID) {
            base.Remove(aID);
        }

        public new void Clear() {
            base.Clear();
        }

        public new IList<IRecollectionData> Enumerate() {
            return base.Enumerate();
        }

        public new IRecollectionData Get(string aID) {
            return base.Get(aID);
        }

        public new int Count() {
            return base.Count();
        }

        public new void Add(IRecollectionData aItem) {
            base.Add(aItem);
        }
        #endregion
    }
}