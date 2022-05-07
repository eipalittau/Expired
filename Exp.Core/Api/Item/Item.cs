namespace Exp.Api.Item {
    public sealed class Item : ApiBase<Data.Item.IItemData> {
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

        public new IList<Data.Item.IItemData> Enumerate() {
            return base.Enumerate();
        }

        public new Data.Item.IItemData Get(string aID) {
            return base.Get(aID);
        }

        public new int Count() {
            return base.Count();
        }

        public new void Add(Data.Item.IItemData aItem) {
            base.Add(aItem);
        }
        #endregion
    }
}