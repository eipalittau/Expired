namespace Exp.Data.Item {
    public interface IItemTypeDataBase : IDataBase {
        List<Player.ISlotData> EquipmentSlotList { get; }
        IItemTypeData? Parent { get; init; }
    }
}