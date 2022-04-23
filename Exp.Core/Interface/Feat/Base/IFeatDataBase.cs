namespace Exp.Data.Feat {
    public interface IFeatDataBase<T> : IDataBase {
        General.TierEnum Tier { get; set; }
        General.ActionTypeEnum? ActionType { get; set; }
        List<T> PrerequisiteList { get; }
    }
}