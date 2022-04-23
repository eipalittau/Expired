using Exp.Data.Feat;
using Exp.Data.General;

namespace Exp.DefaultMod.Feat.Wizardry {
    internal sealed class ImprovedMagicWave : FeatDataBase<IWizardryData>, IWizardryData {
        #region Konstruktor
        internal ImprovedMagicWave()
            : base(nameof(ImprovedMagicWave), 1300, TierEnum.Two, ActionTypeEnum.Standard, Api.Feat.Wizardry.Singleton.Get("MagicWave")) {
            Name.Set(Util.LanguageEnum.Deutsch, "Verbesserte magische Welle");
            Name.Set(Util.LanguageEnum.English, "Improved magic wave");
            Description.Set(Util.LanguageEnum.Deutsch, "");
            Description.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}