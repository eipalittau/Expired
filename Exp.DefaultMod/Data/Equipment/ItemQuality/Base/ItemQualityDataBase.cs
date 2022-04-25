using Exp.Data.Equipment;

namespace Exp.DefaultMod.Equipment.ItemQuality {
    internal abstract class ItemQualityDataBase : DataBase, IItemQualityDataBase {
        #region Properties / Felder
        public IItemQualityDataBase? Downgrade { get; set; }
        public IItemQualityDataBase? Upgrade { get; set; }
        public bool CanBeDestroyed { get; set; }
        public bool IsDefault { get; set; }
        #endregion

        #region Konstruktor
        private protected ItemQualityDataBase(string aID, int aSortWeight, bool aCanBeDestroyed, bool aIsDefault)
            : base(aID, aSortWeight)
            => (CanBeDestroyed, IsDefault) = (aCanBeDestroyed, aIsDefault);
        #endregion
    }
}