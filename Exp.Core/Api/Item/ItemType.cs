namespace Exp.Api.Item {
    public sealed class ItemType : ApiBase<Data.Item.IItemTypeData> {
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

        public new IList<Data.Item.IItemTypeData> Enumerate() {
            return base.Enumerate();
        }

        public new Data.Item.IItemTypeData Get(string aID) {
            return base.Get(aID);
        }

        public new int Count() {
            return base.Count();
        }

        public new void Add(Data.Item.IItemTypeData aItem) {
            base.Add(aItem);
        }
        #endregion
    }
}