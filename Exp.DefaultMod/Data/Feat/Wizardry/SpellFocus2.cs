using Exp.Data.Feat;
using Exp.Data.General;

namespace Exp.DefaultMod.Feat.Wizardry {
    internal sealed class SpellFocus2 : FeatDataBase<IWizardryData>, IWizardryData {
        #region Konstruktor
        internal SpellFocus2()
            : base(nameof(SpellFocus2), 1400, TierEnum.Two, null, Api.Feat.Wizardry.Singleton.Get("SpellFocus")) {
            Name.Set(Util.LanguageEnum.Deutsch, "Zauberfokus++");
            Name.Set(Util.LanguageEnum.English, "Spell focus++");
            Description.Set(Util.LanguageEnum.Deutsch, "");
            Description.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}