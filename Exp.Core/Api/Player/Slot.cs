namespace Exp.Api.Player {
    public sealed class Slot : ApiBase<Data.Player.ISlotData> {
        #region Properties / Felder
        public static Slot Singleton { get; } = new();
        #endregion

        #region Konstruktor
        private Slot() : base() { }
        #endregion

        #region Methoden
        public new void Remove(string aID) {
            base.Remove(aID);
        }

        public new void Clear() {
            base.Clear();
        }

        public new IList<Data.Player.ISlotData> List() {
            return base.List();
        }

        public new Data.Player.ISlotData Get(string aID) {
            return base.Get(aID);
        }

        public new int Count() {
            return base.Count();
        }

        public new void Add(Data.Player.ISlotData aItem) {
            base.Add(aItem);
        }
        #endregion
    }
}