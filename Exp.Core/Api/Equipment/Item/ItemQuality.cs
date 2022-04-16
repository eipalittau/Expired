namespace Exp.Api.Equipment {
    public sealed class ItemQuality : ApiBase<Data.Equipment.ItemQualityData> {
        #region Properties / Felder
        private static readonly ItemQuality mSingleton = new();
        #endregion

        #region Konstruktor
        internal ItemQuality() : base() {
            Add("Normal", null, null, true, true, 100);
        }
        #endregion

        #region Methoden
        public static ItemQuality Singleton {
            get {
                return mSingleton;
            }
        }

        public void Add(string aID, string? aDowngradeID, string? aUpgradeID, bool aCanBeDestroyed, bool aIsDefault, int aSortWeight = 0) {
            base.Add(new Data.Equipment.ItemQualityData(aID, aDowngradeID, aUpgradeID, aSortWeight, aCanBeDestroyed, aIsDefault));
        }
        #endregion
    }
}