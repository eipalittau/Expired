namespace Exp.Data.Feat.Wizardry {
    public interface IWizardryData : IFeatDataBase {
        List<IWizardryData> PrerequisiteList { get; }
    }
}