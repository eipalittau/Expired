namespace Exp.Data.Feat.Wonder {
    public interface IWonderData : IFeatDataBase {
        List<IWonderData> PrerequisiteList { get; }
    }
}