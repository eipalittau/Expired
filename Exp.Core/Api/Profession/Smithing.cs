using Exp.Data.Profession.Smithing;

namespace Exp.Api.Profession {
    public sealed class Smithing : ApiBase<ISmithingData> {
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

        public new IList<ISmithingData> Enumerate() {
            return base.Enumerate();
        }

        public new ISmithingData Get(string aID) {
            return base.Get(aID);
        }

        public new int Count() {
            return base.Count();
        }

        public new void Add(ISmithingData aItem) {
            base.Add(aItem);
        }
        #endregion
    }
}