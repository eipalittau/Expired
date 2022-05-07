namespace Exp.Data.Feat {
    public interface IAuraData : IDataBase {
        General.ITierData Tier { get; set; }
        General.IActionTypeData? ActionType { get; set; }
        List<IAuraData> PrerequisiteList { get; }
        Util.LanguageBasedData EffektDescription { get; }
    }
}