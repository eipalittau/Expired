namespace Exp.Data.Feat {
    public interface IAuraData : IFeatDataBase {
        List<IAuraData> PrerequisiteList { get; }
    }
}