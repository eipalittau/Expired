namespace Exp.Data.Feat {
    public interface ISmithingData : IDataBase {
        General.ITierData Tier { get; set; }
        List<Equipment.IItemTypeData> ItemTypeList { get; init; }
        Util.LanguageBasedData EffektDescription { get; }
    }
}