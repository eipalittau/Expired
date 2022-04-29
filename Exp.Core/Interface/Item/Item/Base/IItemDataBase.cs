namespace Exp.Data.Item {
    public interface IItemDataBase : IDataBase {
        IItemTypeData ItemType { get; set; }
        bool AlwaysAvailable { get; set; }
    }
}