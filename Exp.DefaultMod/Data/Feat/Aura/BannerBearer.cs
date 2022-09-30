using Exp.Data.Feat.Aura;
using Exp.Util.Enumeration;

namespace Exp.DefaultMod.Feat.Aura
{
    public sealed class BannerBearer : AuraDataBase, IAuraData {
        #region Konstruktor
        private BannerBearer()
            : base(nameof(BannerBearer), 1800, Api.General.Tier.Singleton.Get(nameof(General.Tier.Two))) {
            Name.Set(LanguageEnum.Deutsch, "Bannerträger");
            Name.Set(LanguageEnum.English, "Banner bearer");
            LoreDescription.Set(LanguageEnum.Deutsch, "");
            LoreDescription.Set(LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new BannerBearer());
        }
        #endregion
    }
}