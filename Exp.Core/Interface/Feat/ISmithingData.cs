namespace Exp.Data.Feat {
    public interface ISmithingData : IDataBase {
        General.ITierData Tier { get; set; }
        List<Item.IItemTypeData> ItemTypeList { get; init; }
        Util.LanguageBasedData EffektDescription { get; }
    }
}