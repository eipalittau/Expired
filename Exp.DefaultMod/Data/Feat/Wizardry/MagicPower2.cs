using Exp.Data.Feat;
using Exp.Data.General;

namespace Exp.DefaultMod.Feat.Wizardry {
    internal sealed class MagicPower2 : FeatDataBase<IWizardryData>, IWizardryData {
        #region Konstruktor
        internal MagicPower2()
            : base(nameof(MagicPower2), 1500, Api.General.Tier.Singleton.Get(nameof(Data.General.Tier.Two)), null, Api.Feat.Wizardry.Singleton.Get(nameof(MagicPower))) {
            Name.Set(Util.LanguageEnum.Deutsch, "Zaubermacht++");
            Name.Set(Util.LanguageEnum.English, "Magic power++");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}