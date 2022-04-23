namespace Exp.Data.Equipment {
    public interface IItemTypeDataBase : IDataBase {
        List<ISlotData> EquipmentSlotList { get; }
        IItemTypeData? Parent { get; init; }
    }
}