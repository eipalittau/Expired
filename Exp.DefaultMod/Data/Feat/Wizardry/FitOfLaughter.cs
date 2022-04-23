using Exp.Data.Feat;
using Exp.Data.General;

namespace Exp.DefaultMod.Feat.Wizardry {
    internal sealed class FitOfLaughter : FeatDataBase<IWizardryData>, IWizardryData {
        #region Konstruktor
        internal FitOfLaughter()
            : base(nameof(FitOfLaughter), 600, TierEnum.One, ActionTypeEnum.Standard) {
            Name.Set(Util.LanguageEnum.Deutsch, "Lachanfall");
            Name.Set(Util.LanguageEnum.English, "Fit of laughter");
            Description.Set(Util.LanguageEnum.Deutsch, "");
            Description.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}