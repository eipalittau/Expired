namespace Exp.Api.Feat {
    public sealed class Hidden : ApiBase<Data.Feat.IHiddenData> {
        #region Properties / Felder
        public static Hidden Singleton { get; } = new();
        #endregion

        #region Konstruktor
        internal Hidden() : base() { }
        #endregion

        #region Methoden
        public new void Remove(string aID) {
            base.Remove(aID);
        }

        public new void Clear() {
            base.Clear();
        }

        public new IList<Data.Feat.IHiddenData> Enumerate() {
            return base.Enumerate();
        }

        public new Data.Feat.IHiddenData Get(string aID) {
            return base.Get(aID);
        }

        public new int Count() {
            return base.Count();
        }

        public new void Add(Data.Feat.IHiddenData aItem) {
            base.Add(aItem);
        }
        #endregion
    }
}