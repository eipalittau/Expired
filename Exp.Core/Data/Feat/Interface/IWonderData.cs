namespace Exp.Data.Feat {
    public interface IWonderData : IFeatDataBase {
        List<IWonderData> PrerequisiteList { get; }
    }
}