using Exp.Data.Feat;

namespace Exp.DefaultMod.Feat.Wizardry {
    internal sealed class Shield : FeatDataBase<IWizardryData>, IWizardryData {
        #region Konstruktor
        internal Shield()
            : base(nameof(Shield), 400, Api.General.Tier.Singleton.Get(nameof(Data.General.Tier.One)), Api.General.ActionType.Singleton.Get(nameof(Data.General.ActionType.Free))) {
            Name.Set(Util.LanguageEnum.Deutsch, "Schild");
            Name.Set(Util.LanguageEnum.English, "Shield");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}