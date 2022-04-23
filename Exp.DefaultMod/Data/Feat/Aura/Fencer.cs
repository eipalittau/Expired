using Exp.Data.Feat;
using Exp.Data.General;

namespace Exp.DefaultMod.Feat.Aura {
    internal sealed class Fencer : FeatDataBase<IAuraData>, IAuraData {
        #region Konstruktor
        internal Fencer()
            : base(nameof(Fencer), 100, TierEnum.One, null) {
            Name.Set(Util.LanguageEnum.Deutsch, "Aura des Fechters");
            Name.Set(Util.LanguageEnum.English, "Aura of the fencer");
            Description.Set(Util.LanguageEnum.Deutsch, "");
            Description.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}