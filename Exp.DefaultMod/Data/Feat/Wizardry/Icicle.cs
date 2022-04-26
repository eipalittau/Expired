using Exp.Data.Feat;

namespace Exp.DefaultMod.Feat.Wizardry {
    internal sealed class Icicle : FeatDataBase<IWizardryData>, IWizardryData {
        #region Konstruktor
        internal Icicle()
            : base(nameof(Icicle), 900, Api.General.Tier.Singleton.Get(nameof(Data.General.Tier.Two)), Api.General.ActionType.Singleton.Get(nameof(Data.General.ActionType.Move))) {
            Name.Set(Util.LanguageEnum.Deutsch, "Eiszapfen");
            Name.Set(Util.LanguageEnum.English, "Icicle");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}