using Exp.Data.Feat;

namespace Exp.DefaultMod.Feat.Wizardry {
    internal sealed class Metamagic : FeatDataBase<IWizardryData>, IWizardryData {
        #region Konstruktor
        internal Metamagic()
            : base(nameof(Metamagic), 1200, Api.General.Tier.Singleton.Get(nameof(Data.General.Tier.Two)), null) {
            Name.Set(Util.LanguageEnum.Deutsch, "Metamagie");
            Name.Set(Util.LanguageEnum.English, "Metamagic");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}