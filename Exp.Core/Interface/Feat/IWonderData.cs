namespace Exp.Data.Feat {
    public interface IWonderData : IDataBase {
        General.ITierData Tier { get; set; }
        General.IActionTypeData? ActionType { get; set; }
        List<IWonderData> PrerequisiteList { get; }
        Util.LanguageBasedData EffektDescription { get; }
    }
}