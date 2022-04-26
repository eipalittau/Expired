namespace Exp.Data.Feat {
    public interface IFeatDataBase<T> : IDataBase {
        General.ITierData Tier { get; set; }
        General.IActionTypeData? ActionType { get; set; }
        List<T> PrerequisiteList { get; }
        Util.LanguageBasedData EffektDescription { get; }
    }
}