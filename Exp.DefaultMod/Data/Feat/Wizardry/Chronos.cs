using Exp.Data.Feat;

namespace Exp.DefaultMod.Feat.Wizardry {
    internal sealed class Chronos : FeatDataBase<IWizardryData>, IWizardryData {
        #region Konstruktor
        internal Chronos()
            : base(nameof(Chronos), 1600, Api.General.Tier.Singleton.Get(nameof(Data.General.Tier.Three)), Api.General.ActionType.Singleton.Get(nameof(Data.General.ActionType.Free))) {
            Name.Set(Util.LanguageEnum.Deutsch, "Chronos");
            Name.Set(Util.LanguageEnum.English, "Chronos");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}