using Exp.Data.Feat;

namespace Exp.DefaultMod.Feat.Wizardry {
    internal sealed class HoldPerson : FeatDataBase<IWizardryData>, IWizardryData {
        #region Konstruktor
        internal HoldPerson()
            : base(nameof(HoldPerson), 1100, Api.General.Tier.Singleton.Get(nameof(Data.General.Tier.Two)), Api.General.ActionType.Singleton.Get(nameof(Data.General.ActionType.Standard))) {
            Name.Set(Util.LanguageEnum.Deutsch, "Person festhalten");
            Name.Set(Util.LanguageEnum.English, "Hold person");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}