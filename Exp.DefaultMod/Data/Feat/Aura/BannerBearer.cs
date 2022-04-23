using Exp.Data.Feat;
using Exp.Data.General;

namespace Exp.DefaultMod.Feat.Aura {
    internal sealed class BannerBearer : FeatDataBase<IAuraData>, IAuraData {
        #region Konstruktor
        internal BannerBearer()
            : base(nameof(BannerBearer), 1800, TierEnum.Two, null) {
            Name.Set(Util.LanguageEnum.Deutsch, "Bannerträger");
            Name.Set(Util.LanguageEnum.English, "Banner bearer");
            Description.Set(Util.LanguageEnum.Deutsch, "");
            Description.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}