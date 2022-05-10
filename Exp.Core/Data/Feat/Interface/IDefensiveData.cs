namespace Exp.Data.Feat {
    public interface IDefensiveData : IFeatDataBase {
        List<IDefensiveData> PrerequisiteList { get; }
    }
}