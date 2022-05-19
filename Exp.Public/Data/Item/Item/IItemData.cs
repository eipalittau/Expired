using Exp.Data.Item.ItemType;

namespace Exp.Data.Item.Item {
    public interface IItemData : IDataBase {
        IItemTypeData ItemType { get; set; }
        bool AlwaysAvailable { get; set; }
    }
}