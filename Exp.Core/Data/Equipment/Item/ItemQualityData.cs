namespace Exp.Data.Equipment {
    public sealed class ItemQualityData : DataBase {
        #region Properties / Felder
        public ItemQualityData? Downgrade { get; set; }
        public ItemQualityData? Upgrade { get; set; }
        public bool CanBeDestroyed { get; set; }
        public bool IsDefault { get; set; }
        public EffectData Effect { get; init; }
        #endregion

        #region Konstruktor
        internal ItemQualityData(int aID, string aName, string aDescription, uint aSortOrder, string aOrigin, ItemQualityData? aDowngrade, ItemQualityData? aUpgrade, bool aCanBeDestroyed, bool aIsDefault, EffectData aEffect)
            : base(aID, aName, aDescription, aSortOrder, aOrigin) {
            Downgrade = aDowngrade;
            Upgrade = aUpgrade;
            CanBeDestroyed = aCanBeDestroyed;
            IsDefault = aIsDefault;
            Effect = aEffect;
        }
        #endregion
    }
}