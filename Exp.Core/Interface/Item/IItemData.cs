namespace Exp.Data.Item {
    public interface IItemData : IDataBase {
        IItemTypeData ItemType { get; set; }
        bool AlwaysAvailable { get; set; }
    }
}