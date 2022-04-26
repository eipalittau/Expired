using Exp.Data.Feat;

namespace Exp.DefaultMod.Feat.Wizardry {
    internal sealed class SpellFocus2 : FeatDataBase<IWizardryData>, IWizardryData {
        #region Konstruktor
        internal SpellFocus2()
            : base(nameof(SpellFocus2), 1400, Api.General.Tier.Singleton.Get(nameof(Data.General.Tier.Two)), null, Api.Feat.Wizardry.Singleton.Get(nameof(SpellFocus))) {
            Name.Set(Util.LanguageEnum.Deutsch, "Zauberfokus++");
            Name.Set(Util.LanguageEnum.English, "Spell focus++");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}