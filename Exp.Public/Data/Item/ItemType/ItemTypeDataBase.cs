using Exp.Data.Player.Slot;

namespace Exp.Data.Item.ItemType {
    public abstract class ItemTypeDataBase : DataBase {
        #region Properties / Felder
        public List<ISlotData> EquipmentSlotList { get; } = new();
        public IItemTypeData? Parent { get; init; }
        #endregion

        #region Konstruktor
        protected ItemTypeDataBase(string aID, int aSortWeight, IItemTypeData aParent, params ISlotData[] aEquipmentSlots)
            : this(aID, aSortWeight, aEquipmentSlots)
            => Parent = aParent;

        protected ItemTypeDataBase(string aID, int aSortWeight, params ISlotData[] aEquipmentSlots)
            : base(aID, aSortWeight) {
            if (aEquipmentSlots == null || aEquipmentSlots.Length == 0) {
                EquipmentSlotList = new();
            } else {
                EquipmentSlotList = aEquipmentSlots.ToList();
            }

        }
        #endregion

        #region Methoden
        protected static void AddInstance(IItemTypeData aInstance) {
            Api.Item.ItemType.Singleton.Add(aInstance);
        }
        #endregion
    }
}