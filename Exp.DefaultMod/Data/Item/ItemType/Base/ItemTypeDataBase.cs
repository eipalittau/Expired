using Exp.Data.Item;

namespace Exp.DefaultMod.Item.ItemType {
    internal abstract class ItemTypeDataBase : DataBase, IItemTypeDataBase {
        #region Properties / Felder
        public List<Data.Player.ISlotData> EquipmentSlotList { get; } = new();
        public IItemTypeData? Parent { get; init; }
        #endregion

        #region Konstruktor
        private protected ItemTypeDataBase(string aID, int aSortWeight, IItemTypeData? aParent, params Data.Player.ISlotData[] aEquipmentSlots)
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