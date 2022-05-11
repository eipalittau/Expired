namespace Exp.Api.Misc {
    public sealed class Aptitude : ApiBase<Data.Misc.IAptitudeData> {
        #region Properties / Felder
        public static Aptitude Singleton { get; } = new();
        #endregion

        #region Konstruktor
        private Aptitude() : base() { }
        #endregion

        #region Methoden
        public new void Remove(string aID) {
            base.Remove(aID);
        }

        public new void Clear() {
            base.Clear();
        }

        public new IList<Data.Misc.IAptitudeData> Enumerate() {
            return base.Enumerate();
        }

        public new Data.Misc.IAptitudeData Get(string aID) {
            return base.Get(aID);
        }

        public new int Count() {
            return base.Count();
        }

        public new void Add(Data.Misc.IAptitudeData aItem) {
            base.Add(aItem);
        }
        #endregion
    }
}