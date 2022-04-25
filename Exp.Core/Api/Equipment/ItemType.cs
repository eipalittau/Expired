namespace Exp.Api.Equipment {
    public sealed class ItemType : ApiBase<Data.Equipment.IItemTypeData> {
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

        public new IList<Data.Equipment.IItemTypeData> List() {
            return base.List();
        }

        public new Data.Equipment.IItemTypeData Get(string aID) {
            return base.Get(aID);
        }

        public new int Count() {
            return base.Count();
        }

        public new void Add(Data.Equipment.IItemTypeData aItem) {
            base.Add(aItem);
        }
        #endregion
    }
}