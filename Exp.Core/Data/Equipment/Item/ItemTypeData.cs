namespace Exp.Data.Equipment {
    public sealed class ItemTypeData : DataBase {
        #region Properties / Felder
        public List<SlotData> EquipmentSlot { get; } = new();
        public ItemTypeData? Parent { get; private set; }
        #endregion

        #region Konstruktor
        internal ItemTypeData(string aID, int aSortWeight, ItemTypeData? aParent, params SlotData[] aEquipmentSlot)
            : base(aID, aSortWeight)
            => (Parent, EquipmentSlot) = (aParent, aEquipmentSlot.ToList());
        #endregion
    }
}