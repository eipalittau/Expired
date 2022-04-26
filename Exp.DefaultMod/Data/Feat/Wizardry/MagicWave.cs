using Exp.Data.Feat;

namespace Exp.DefaultMod.Feat.Wizardry {
    internal sealed class MagicWave : FeatDataBase<IWizardryData>, IWizardryData {
        #region Konstruktor
        internal MagicWave()
            : base(nameof(MagicWave), 100, Api.General.Tier.Singleton.Get(nameof(Data.General.Tier.One)), Api.General.ActionType.Singleton.Get(nameof(Data.General.ActionType.Standard))) {
            Name.Set(Util.LanguageEnum.Deutsch, "Magische Welle");
            Name.Set(Util.LanguageEnum.English, "Magic wave");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}