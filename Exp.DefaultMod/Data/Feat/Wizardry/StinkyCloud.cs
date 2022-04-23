using Exp.Data.Feat;
using Exp.Data.General;

namespace Exp.DefaultMod.Feat.Wizardry {
    internal sealed class StinkyCloud : FeatDataBase<IWizardryData>, IWizardryData {
        #region Konstruktor
        internal StinkyCloud()
            : base(nameof(StinkyCloud), 200, TierEnum.One, ActionTypeEnum.Standard) {
            Name.Set(Util.LanguageEnum.Deutsch, "Stinkende Wolke");
            Name.Set(Util.LanguageEnum.English, "Stinky cloud");
            Description.Set(Util.LanguageEnum.Deutsch, "");
            Description.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}