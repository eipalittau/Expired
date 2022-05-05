namespace Exp.Data.Feat {
    public interface IWizardryData : IDataBase {
        General.ITierData Tier { get; set; }
        General.IActionTypeData? ActionType { get; set; }
        List<IWizardryData> PrerequisiteList { get; }
        Util.LanguageBasedData EffektDescription { get; }
    }
}