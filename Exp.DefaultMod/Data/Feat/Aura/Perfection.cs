using Exp.Data.Feat;
using Exp.Data.General;

namespace Exp.DefaultMod.Feat.Aura {
    internal sealed class Perfection : FeatDataBase<IAuraData>, IAuraData {
        #region Konstruktor
        internal Perfection()
            : base(nameof(Perfection), 1600, TierEnum.Two, null) {
            Name.Set(Util.LanguageEnum.Deutsch, "Perfektion");
            Name.Set(Util.LanguageEnum.English, "Perfection");
            Description.Set(Util.LanguageEnum.Deutsch, "");
            Description.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}