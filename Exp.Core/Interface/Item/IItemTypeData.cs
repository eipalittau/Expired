namespace Exp.Data.Item {
    public interface IItemTypeData : IDataBase {
        List<Player.ISlotData> EquipmentSlotList { get; }
        IItemTypeData? Parent { get; init; }
    }
}