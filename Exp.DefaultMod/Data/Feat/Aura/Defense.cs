using Exp.Data.Feat;
using Exp.Data.General;

namespace Exp.DefaultMod.Feat.Aura {
    internal sealed class Defense : FeatDataBase<IAuraData>, IAuraData {
        #region Konstruktor
        internal Defense()
            : base(nameof(Defense), 300, TierEnum.One, null) {
            Name.Set(Util.LanguageEnum.Deutsch, "Aura der Verteidigung");
            Name.Set(Util.LanguageEnum.English, "Aura of defense");
            Description.Set(Util.LanguageEnum.Deutsch, "");
            Description.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}