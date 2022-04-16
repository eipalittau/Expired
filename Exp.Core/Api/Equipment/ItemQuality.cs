namespace Exp.Api.Equipment {
    public sealed class ItemQuality : ApiBase<Data.Equipment.ItemQualityData> {
        #region Properties / Felder
        private static readonly ItemQuality mSingleton = new();
        #endregion

        #region Konstruktor
        internal ItemQuality() : base() {
            Add("Normal", null, null, 100, string.Empty, true, true);
        }
        #endregion

        #region Methoden
        public static ItemQuality Singleton {
            get {
                return mSingleton;
            }
        }

        public void Add(string aID, string? aDowngradeID, string? aUpgradeID, bool aCanBeDestroyed, bool aIsDefault) {
            Add(aID, aDowngradeID, aUpgradeID, base.Count() + 1, aCanBeDestroyed, aIsDefault);
        }

        public void Add(string aID, string? aDowngradeID, string? aUpgradeID, int aSortWeight, bool aCanBeDestroyed, bool aIsDefault) {
            Add(aID, aDowngradeID, aUpgradeID, aSortWeight, base.GetOriginNameCaller(), aCanBeDestroyed, aIsDefault);
        }

        private void Add(string aID, string? aDowngradeID, string? aUpgradeID, int aSortWeight, string aOrigin, bool aCanBeDestroyed, bool aIsDefault) {
            base.Add(new Data.Equipment.ItemQualityData(aID, aDowngradeID, aUpgradeID, aSortWeight, aOrigin, aCanBeDestroyed, aIsDefault));
        }
        #endregion
    }
}