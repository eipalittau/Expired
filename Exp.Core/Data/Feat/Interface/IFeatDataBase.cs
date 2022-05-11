namespace Exp.Data.Feat {
    public interface IFeatDataBase : IDataBase {
        General.ITierData Tier { get; set; }
        General.IActionTypeData? ActionType { get; set; }
        Util.LanguageBasedData EffektDescription { get; }
    }
}