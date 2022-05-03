using Exp.Data.Feat;

namespace Exp.DefaultMod.Feat.Aura {
    internal sealed class BannerBearer : AuraDataBase, IAuraData {
        #region Konstruktor
        internal BannerBearer()
            : base(nameof(BannerBearer), 1800, Api.General.Tier.Singleton.Get(nameof(General.Tier.Two)), null) {
            Name.Set(Util.LanguageEnum.Deutsch, "Bannerträger");
            Name.Set(Util.LanguageEnum.English, "Banner bearer");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}