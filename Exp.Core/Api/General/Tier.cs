namespace Exp.Api.General {
    public sealed class Tier : ApiBase<Data.General.ITierData> {
        #region Properties / Felder
        public static Tier Singleton { get; } = new();
        #endregion

        #region Konstruktor
        private Tier() : base() { }
        #endregion

        #region Methoden
        internal new void Remove(string aID) {
            base.Remove(aID);
        }

        internal new void Clear() {
            base.Clear();
        }

        public new IList<Data.General.ITierData> Enumerate() {
            return base.Enumerate();
        }

        public new Data.General.ITierData Get(string aID) {
            return base.Get(aID);
        }

        public new int Count() {
            return base.Count();
        }

        internal new void Add(Data.General.ITierData aItem) {
            base.Add(aItem);
        }
        #endregion
    }
}