using Exp.Data.Feat;

namespace Exp.DefaultMod.Feat.Wizardry {
    internal sealed class StinkyCloud : FeatDataBase<IWizardryData>, IWizardryData {
        #region Konstruktor
        internal StinkyCloud()
            : base(nameof(StinkyCloud), 200, Api.General.Tier.Singleton.Get(nameof(Data.General.Tier.One)), Api.General.ActionType.Singleton.Get(nameof(Data.General.ActionType.Standard))) {
            Name.Set(Util.LanguageEnum.Deutsch, "Stinkende Wolke");
            Name.Set(Util.LanguageEnum.English, "Stinky cloud");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}