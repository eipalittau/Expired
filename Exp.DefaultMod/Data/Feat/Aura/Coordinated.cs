using Exp.Data.Feat;
using Exp.Data.General;

namespace Exp.DefaultMod.Feat.Aura {
    internal sealed class Coordinated : FeatDataBase<IAuraData>, IAuraData {
        #region Konstruktor
        internal Coordinated()
            : base(nameof(Coordinated), 1200, TierEnum.One, null) {
            Name.Set(Util.LanguageEnum.Deutsch, "Koordiniert");
            Name.Set(Util.LanguageEnum.English, "Coordinated");
            Description.Set(Util.LanguageEnum.Deutsch, "");
            Description.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}