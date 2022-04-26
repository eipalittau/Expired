using Exp.Data.Feat;

namespace Exp.DefaultMod.Feat.Wizardry {
    internal sealed class Dionysos : FeatDataBase<IWizardryData>, IWizardryData {
        #region Konstruktor
        internal Dionysos()
            : base(nameof(Dionysos), 1700, Api.General.Tier.Singleton.Get(nameof(Data.General.Tier.Three)), Api.General.ActionType.Singleton.Get(nameof(Data.General.ActionType.Standard))) {
            Name.Set(Util.LanguageEnum.Deutsch, "Dionysos");
            Name.Set(Util.LanguageEnum.English, "Dionysos");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}