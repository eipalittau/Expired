using Exp.Data.Item.Item;

namespace Exp.Api.Item {
    public sealed class Item : ApiBase<IItemData> {
        #region Properties / Felder
        public static Item Singleton { get; } = new();
        #endregion

        #region Konstruktor
        private Item() : base() { }
        #endregion

        #region Methoden
        public new void Remove(string aID) {
            base.Remove(aID);
        }

        public new void Clear() {
            base.Clear();
        }

        public new IList<IItemData> Enumerate() {
            return base.Enumerate();
        }

        public new IItemData Get(string aID) {
            return base.Get(aID);
        }

        public new int Count() {
            return base.Count();
        }

        public new void Add(IItemData aItem) {
            base.Add(aItem);
        }
        #endregion
    }
}