namespace Exp.Api.Item {
    public sealed class ItemQuality : ApiBase<Data.Item.IItemQualityData> {
        #region Properties / Felder
        public static ItemQuality Singleton { get; } = new();
        #endregion

        #region Konstruktor
        private ItemQuality() : base() { }
        #endregion

        #region Methoden
        public new void Remove(string aID) {
            base.Remove(aID);
        }

        public new void Clear() {
            base.Clear();
        }

        public new IList<Data.Equipment.IItemQualityData> List() {
            return base.List();
        }

        public new Data.Equipment.IItemQualityData Get(string aID) {
            return base.Get(aID);
        }

        public new int Count() {
            return base.Count();
        }

        public new void Add(Data.Equipment.IItemQualityData aItem) {
            base.Add(aItem);
        }
        #endregion
    }
}