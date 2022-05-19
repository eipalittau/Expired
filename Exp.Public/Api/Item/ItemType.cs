using Exp.Data.Item.ItemType;

namespace Exp.Api.Item {
    public sealed class ItemType : ApiBase<IItemTypeData> {
        #region Properties / Felder
        public static ItemType Singleton { get; } = new();
        #endregion

        #region Konstruktor
        private ItemType() : base() { }
        #endregion

        #region Methoden
        public new void Remove(string aID) {
            base.Remove(aID);
        }

        public new void Clear() {
            base.Clear();
        }

        public new IList<IItemTypeData> Enumerate() {
            return base.Enumerate();
        }

        public new IItemTypeData Get(string aID) {
            return base.Get(aID);
        }

        public new int Count() {
            return base.Count();
        }

        public new void Add(IItemTypeData aItem) {
            base.Add(aItem);
        }
        #endregion
    }
}