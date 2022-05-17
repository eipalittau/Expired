using Exp.Data.Item.ItemQuality;

namespace Exp.Api.Item {
    public sealed class ItemQuality : ApiBase<IItemQualityData> {
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

        public new IList<IItemQualityData> Enumerate() {
            return base.Enumerate();
        }

        public new IItemQualityData Get(string aID) {
            return base.Get(aID);
        }

        public new int Count() {
            return base.Count();
        }

        public new void Add(IItemQualityData aItem) {
            base.Add(aItem);
        }
        #endregion
    }
}