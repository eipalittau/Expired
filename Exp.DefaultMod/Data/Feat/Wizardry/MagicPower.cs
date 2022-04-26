using Exp.Data.Feat;

namespace Exp.DefaultMod.Feat.Wizardry {
    internal sealed class MagicPower : FeatDataBase<IWizardryData>, IWizardryData {
        #region Konstruktor
        internal MagicPower()
            : base(nameof(MagicPower), 800, Api.General.Tier.Singleton.Get(nameof(Data.General.Tier.One)), null) {
            Name.Set(Util.LanguageEnum.Deutsch, "Zaubermacht");
            Name.Set(Util.LanguageEnum.English, "Magic power");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}