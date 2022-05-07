namespace Exp.DefaultMod.Feat.Aura {
    public sealed class BannerBearer : Exp.Data.Feat.AuraDataBase, Exp.Data.Feat.IAuraData {
        #region Konstruktor
        private BannerBearer()
            : base(nameof(BannerBearer), 1800, Api.General.Tier.Singleton.Get(nameof(General.Tier.Two)), null) {
            Name.Set(Util.LanguageEnum.Deutsch, "Bannerträger");
            Name.Set(Util.LanguageEnum.English, "Banner bearer");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new BannerBearer());
        }
        #endregion
    }
}