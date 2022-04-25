namespace Exp.Api.Feat {
    public sealed class Wonder : ApiBase<Data.Feat.IWonderData> {
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

        public new IList<Data.Feat.IWonderData> List() {
            return base.List();
        }

        public new Data.Feat.IWonderData Get(string aID) {
            return base.Get(aID);
        }

        public new int Count() {
            return base.Count();
        }

        public new void Add(Data.Feat.IWonderData aItem) {
            base.Add(aItem);
        }
        #endregion
    }
}