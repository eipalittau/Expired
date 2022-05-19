using Exp.Data.General.Tier;

namespace Exp.Api.General {
    public sealed class Tier : ApiBase<ITierData> {
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

        public new IList<ITierData> Enumerate() {
            return base.Enumerate();
        }

        public new ITierData Get(string aID) {
            return base.Get(aID);
        }

        public new int Count() {
            return base.Count();
        }

        internal new void Add(ITierData aItem) {
            base.Add(aItem);
        }
        #endregion
    }
}