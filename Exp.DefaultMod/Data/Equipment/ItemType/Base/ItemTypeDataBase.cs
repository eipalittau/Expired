using Exp.Data.Equipment;

namespace Exp.DefaultMod.Equipment.ItemType {
    internal abstract class ItemTypeDataBase : DataBase, IItemTypeDataBase {
        #region Properties / Felder
        public List<ISlotData> EquipmentSlotList { get; } = new();
        public IItemTypeData? Parent { get; init; }
        #endregion

        #region Konstruktor
        private protected ItemTypeDataBase(string aID, int aSortWeight, IItemTypeData? aParent, params ISlotData[] aEquipmentSlots)
            : base(aID, aSortWeight) {
            Parent = aParent;
            if (aEquipmentSlots == null || aEquipmentSlots.Length == 0) {
                EquipmentSlotList = new();
            } else {
                EquipmentSlotList = aEquipmentSlots.ToList();
            }

        }
        #endregion
    }
}