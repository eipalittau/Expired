namespace Exp.Data.Feat {
    public interface IWizardryData : IFeatDataBase {
        List<IWizardryData> PrerequisiteList { get; }
    }
}