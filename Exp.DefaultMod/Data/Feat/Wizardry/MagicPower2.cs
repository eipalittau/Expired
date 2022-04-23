using Exp.Data.Feat;
using Exp.Data.General;

namespace Exp.DefaultMod.Feat.Wizardry {
    internal sealed class MagicPower2 : FeatDataBase<IWizardryData>, IWizardryData {
        #region Konstruktor
        internal MagicPower2()
            : base(nameof(MagicPower2), 1500, TierEnum.Two, null, Api.Feat.Wizardry.Singleton.Get("MagicPower")) {
            Name.Set(Util.LanguageEnum.Deutsch, "Zaubermacht++");
            Name.Set(Util.LanguageEnum.English, "Magic power++");
            Description.Set(Util.LanguageEnum.Deutsch, "");
            Description.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}