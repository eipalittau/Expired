namespace Exp.Api.Feat {
    public sealed class Aura : ApiBase<Data.Feat.IAuraData> {
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

        public new IList<Data.Feat.IAuraData> Enumerate() {
            return base.Enumerate();
        }

        public new Data.Feat.IAuraData Get(string aID) {
            return base.Get(aID);
        }

        public new int Count() {
            return base.Count();
        }

        public new void Add(Data.Feat.IAuraData aItem) {
            base.Add(aItem);
        }
        #endregion
    }
}