namespace Exp.Data.Feat.Defensive {
    public interface IDefensiveData : IFeatDataBase {
        List<IDefensiveData> PrerequisiteList { get; }
    }
}