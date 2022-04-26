using Exp.Data.Feat;

namespace Exp.DefaultMod.Feat.Wizardry {
    internal sealed class ImprovedMagicWave : FeatDataBase<IWizardryData>, IWizardryData {
        #region Konstruktor
        internal ImprovedMagicWave()
            : base(nameof(ImprovedMagicWave), 1300, Api.General.Tier.Singleton.Get(nameof(Data.General.Tier.Two)), Api.General.ActionType.Singleton.Get(nameof(Data.General.ActionType.Standard)), Api.Feat.Wizardry.Singleton.Get(nameof(MagicWave))) {
            Name.Set(Util.LanguageEnum.Deutsch, "Verbesserte magische Welle");
            Name.Set(Util.LanguageEnum.English, "Improved magic wave");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}