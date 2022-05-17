using Exp.Data.Player.Slot;

namespace Exp.Data.Item.ItemType {
    public interface IItemTypeData : IDataBase {
        List<ISlotData> EquipmentSlotList { get; }
        IItemTypeData? Parent { get; init; }
    }
}