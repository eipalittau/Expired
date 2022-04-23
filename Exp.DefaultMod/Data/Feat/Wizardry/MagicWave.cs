using Exp.Data.Feat;
using Exp.Data.General;

namespace Exp.DefaultMod.Feat.Wizardry {
    internal sealed class MagicWave : FeatDataBase<IWizardryData>, IWizardryData {
        #region Konstruktor
        internal MagicWave()
            : base(nameof(MagicWave), 100, TierEnum.One, ActionTypeEnum.Standard) {
            Name.Set(Util.LanguageEnum.Deutsch, "Magische Welle");
            Name.Set(Util.LanguageEnum.English, "Magic wave");
            Description.Set(Util.LanguageEnum.Deutsch, "");
            Description.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}