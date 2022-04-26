using Exp.Data.Feat;

namespace Exp.DefaultMod.Feat.Wizardry {
    internal sealed class FitOfLaughter : FeatDataBase<IWizardryData>, IWizardryData {
        #region Konstruktor
        internal FitOfLaughter()
            : base(nameof(FitOfLaughter), 600, Api.General.Tier.Singleton.Get(nameof(Data.General.Tier.One)), Api.General.ActionType.Singleton.Get(nameof(Data.General.ActionType.Standard))) {
            Name.Set(Util.LanguageEnum.Deutsch, "Lachanfall");
            Name.Set(Util.LanguageEnum.English, "Fit of laughter");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}