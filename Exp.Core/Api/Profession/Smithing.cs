namespace Exp.Api.Profession {
    public sealed class Smithing : ApiBase<Data.Profession.ISmithingData> {
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

        public new IList<Data.Profession.ISmithingData> Enumerate() {
            return base.Enumerate();
        }

        public new Data.Profession.ISmithingData Get(string aID) {
            return base.Get(aID);
        }

        public new int Count() {
            return base.Count();
        }

        public new void Add(Data.Profession.ISmithingData aItem) {
            base.Add(aItem);
        }
        #endregion
    }
}