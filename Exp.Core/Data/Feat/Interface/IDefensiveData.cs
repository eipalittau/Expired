namespace Exp.Data.Feat {
    public interface IDefensiveData : IDataBase {
        General.ITierData Tier { get; set; }
        General.IActionTypeData? ActionType { get; set; }
        List<IDefensiveData> PrerequisiteList { get; }
        Util.LanguageBasedData EffektDescription { get; }
    }
}