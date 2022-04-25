namespace Exp.Api.Equipment {
    public sealed class Slot : ApiBase<Data.Equipment.ISlotData> {
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

        public new IList<Data.Equipment.ISlotData> List() {
            return base.List();
        }

        public new Data.Equipment.ISlotData Get(string aID) {
            return base.Get(aID);
        }

        public new int Count() {
            return base.Count();
        }

        public new void Add(Data.Equipment.ISlotData aItem) {
            base.Add(aItem);
        }
        #endregion
    }
}