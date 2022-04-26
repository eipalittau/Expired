using Exp.Data.Feat;

namespace Exp.DefaultMod.Feat.Wizardry {
    internal sealed class SpellFocus : FeatDataBase<IWizardryData>, IWizardryData {
        #region Konstruktor
        internal SpellFocus()
            : base(nameof(SpellFocus), 700, Api.General.Tier.Singleton.Get(nameof(Data.General.Tier.One)), null) {
            Name.Set(Util.LanguageEnum.Deutsch, "Zauberfokus");
            Name.Set(Util.LanguageEnum.English, "Spell focus");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}