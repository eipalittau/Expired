using Exp.Data.Feat;

namespace Exp.DefaultMod.Feat.Wizardry {
    internal sealed class Thanos : FeatDataBase<IWizardryData>, IWizardryData {
        #region Konstruktor
        internal Thanos()
            : base(nameof(Thanos), 1800, Api.General.Tier.Singleton.Get(nameof(Data.General.Tier.Three)), Api.General.ActionType.Singleton.Get(nameof(Data.General.ActionType.Standard))) {
            Name.Set(Util.LanguageEnum.Deutsch, "Thanos");
            Name.Set(Util.LanguageEnum.English, "Thanos");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}