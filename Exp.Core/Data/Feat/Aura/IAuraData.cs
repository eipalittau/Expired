namespace Exp.Data.Feat.Aura {
    public interface IAuraData : IFeatDataBase {
        List<IAuraData> PrerequisiteList { get; }
    }
}