using Exp.Data.Feat;
using Exp.Data.General;

namespace Exp.DefaultMod.Feat.Aura {
    internal sealed class Interdisciplinary : FeatDataBase<IAuraData>, IAuraData {
        #region Konstruktor
        internal Interdisciplinary()
            : base(nameof(Interdisciplinary), 1700, TierEnum.Two, null) {
            Name.Set(Util.LanguageEnum.Deutsch, "Interdisziplinär");
            Name.Set(Util.LanguageEnum.English, "Interdisciplinary");
            Description.Set(Util.LanguageEnum.Deutsch, "");
            Description.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}