using Exp.Data.Feat;
using Exp.Data.General;

namespace Exp.DefaultMod.Feat.Wizardry {
    internal sealed class SpellFocus : FeatDataBase<IWizardryData>, IWizardryData {
        #region Konstruktor
        internal SpellFocus()
            : base(nameof(SpellFocus), 700, TierEnum.One, null) {
            Name.Set(Util.LanguageEnum.Deutsch, "Zauberfokus");
            Name.Set(Util.LanguageEnum.English, "Spell focus");
            Description.Set(Util.LanguageEnum.Deutsch, "");
            Description.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}