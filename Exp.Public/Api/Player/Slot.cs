using Exp.Data.Player.Slot;

namespace Exp.Api.Player {
    public sealed class Slot : ApiBase<ISlotData> {
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

        public new IList<ISlotData> Enumerate() {
            return base.Enumerate();
        }

        public new ISlotData Get(string aID) {
            return base.Get(aID);
        }

        public new int Count() {
            return base.Count();
        }

        public new void Add(ISlotData aItem) {
            base.Add(aItem);
        }
        #endregion
    }
}