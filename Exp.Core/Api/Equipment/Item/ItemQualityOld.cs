namespace Exp.Api.Equipment {
    public sealed class ItemQualityOld : ApiBase<Data.Equipment.ItemQualityData> {
        #region Properties / Felder
        private static readonly ItemQualityOld mSingleton = new();
        #endregion

        #region Konstruktor
        internal ItemQualityOld() : base() {
            Add("Normal", null, null, true, true, 100);
        }
        #endregion

        #region Methoden
        public static ItemQualityOld Singleton {
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