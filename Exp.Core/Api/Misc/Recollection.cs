namespace Exp.Api.Misc {
    public sealed class Recollection : ApiBase<Data.Misc.IRecollectionData> {
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

        public new IList<Data.Misc.IRecollectionData> Enumerate() {
            return base.Enumerate();
        }

        public new Data.Misc.IRecollectionData Get(string aID) {
            return base.Get(aID);
        }

        public new int Count() {
            return base.Count();
        }

        public new void Add(Data.Misc.IRecollectionData aItem) {
            base.Add(aItem);
        }
        #endregion
    }
}