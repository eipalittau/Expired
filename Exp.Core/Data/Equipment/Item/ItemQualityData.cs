namespace Exp.Data.Equipment {
    public sealed class ItemQualityData : DataBase {
        #region Properties / Felder
        public string? DowngradeID { get; set; }
        public string? UpgradeID { get; set; }
        public bool CanBeDestroyed { get; set; }
        public bool IsDefault { get; set; }
        #endregion

        #region Konstruktor
        internal ItemQualityData(string aID, string? aDowngradeID, string? aUpgradeID, int aSortWeight, string aOrigin, bool aCanBeDestroyed, bool aIsDefault)
            : base(aID, string.Empty, string.Empty, aSortWeight, aOrigin)
            => (DowngradeID, UpgradeID, CanBeDestroyed, IsDefault) = (aDowngradeID, aUpgradeID, aCanBeDestroyed, aIsDefault);
        #endregion

        #region Methoden

        #endregion
    }
}