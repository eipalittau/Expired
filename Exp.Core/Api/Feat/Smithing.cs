namespace Exp.Api.Feat {
    public sealed class Smithing : ApiBase<Data.Feat.ISmithingData> {
        #region Properties / Felder
        public static Smithing Singleton { get; } = new();
        #endregion

        #region Konstruktor
        private Smithing() : base() { }
        #endregion

        #region Methoden
        public new void Remove(string aID) {
            base.Remove(aID);
        }

        public new void Clear() {
            base.Clear();
        }

        public new IList<Data.Feat.ISmithingData> Enumerate() {
            return base.Enumerate();
        }

        public new Data.Feat.ISmithingData Get(string aID) {
            return base.Get(aID);
        }

        public new int Count() {
            return base.Count();
        }

        public new void Add(Data.Feat.ISmithingData aItem) {
            base.Add(aItem);
        }
        #endregion
    }
}