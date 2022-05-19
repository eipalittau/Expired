using Exp.Data.General.Tier;
using Exp.Data.Item.ItemType;

namespace Exp.Data.Profession.Smithing {
    public interface ISmithingData : IDataBase {
        ITierData Tier { get; set; }
        List<IItemTypeData> ItemTypeList { get; init; }
        Util.LanguageBasedData EffektDescription { get; }
    }
}