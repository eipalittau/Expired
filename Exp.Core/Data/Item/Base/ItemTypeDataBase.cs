namespace Exp.Data.Item {
    public abstract class ItemTypeDataBase : DataBase {
        #region Properties / Felder
        public List<Player.ISlotData> EquipmentSlotList { get; } = new();
        public IItemTypeData? Parent { get; init; }
        #endregion

        #region Konstruktor
        protected ItemTypeDataBase(string aID, int aSortWeight, IItemTypeData? aParent, params Data.Player.ISlotData[] aEquipmentSlots)
            : base(aID, aSortWeight) {
            Parent = aParent;
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