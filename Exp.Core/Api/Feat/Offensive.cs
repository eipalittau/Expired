namespace Exp.Api.Feat {
    public sealed class Offensive : ApiBase<Data.Feat.IOffensiveData> {
        #region Properties / Felder
        public static Offensive Singleton { get; } = new();
        #endregion

        #region Konstruktor
        private Offensive() : base() { }
        #endregion

        #region Methoden
        public new void Remove(string aID) {
            base.Remove(aID);
        }

        public new void Clear() {
            base.Clear();
        }

        public new IList<Data.Feat.IOffensiveData> List() {
            return base.List();
        }

        public new Data.Feat.IOffensiveData Get(string aID) {
            return base.Get(aID);
        }

        public new int Count() {
            return base.Count();
        }

        public new void Add(Data.Feat.IOffensiveData aItem) {
            base.Add(aItem);
        }
        #endregion
    }
}