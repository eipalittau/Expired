using Exp.Data.Feat;

namespace Exp.DefaultMod.Feat.Wizardry {
    internal sealed class Fireball : FeatDataBase<IWizardryData>, IWizardryData {
        #region Konstruktor
        internal Fireball()
            : base(nameof(Fireball), 1000, Api.General.Tier.Singleton.Get(nameof(Data.General.Tier.Two)), Api.General.ActionType.Singleton.Get(nameof(Data.General.ActionType.Standard))) {
            Name.Set(Util.LanguageEnum.Deutsch, "Feuerball");
            Name.Set(Util.LanguageEnum.English, "Fireball");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}