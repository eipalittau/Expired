using Exp.Data.Feat;
using Exp.Data.General;

namespace Exp.DefaultMod.Feat.Wizardry {
    internal sealed class MagicPower : FeatDataBase<IWizardryData>, IWizardryData {
        #region Konstruktor
        internal MagicPower()
            : base(nameof(MagicPower), 800, TierEnum.One, null) {
            Name.Set(Util.LanguageEnum.Deutsch, "Zaubermacht");
            Name.Set(Util.LanguageEnum.English, "Magic power");
            Description.Set(Util.LanguageEnum.Deutsch, "");
            Description.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}