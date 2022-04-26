using Exp.Data.Feat;

namespace Exp.DefaultMod.Feat.Wizardry {
    internal sealed class Reflection : FeatDataBase<IWizardryData>, IWizardryData {
        #region Konstruktor
        internal Reflection()
            : base(nameof(Reflection), 300, Api.General.Tier.Singleton.Get(nameof(Data.General.Tier.One)), Api.General.ActionType.Singleton.Get(nameof(Data.General.ActionType.Standard))) {
            Name.Set(Util.LanguageEnum.Deutsch, "Spiegelbild");
            Name.Set(Util.LanguageEnum.English, "Reflection");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}