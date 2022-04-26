using Exp.Data.Feat;

namespace Exp.DefaultMod.Feat.Aura {
    internal sealed class Will : FeatDataBase<IAuraData>, IAuraData {
        #region Konstruktor
        internal Will()
            : base(nameof(Will), 500, Api.General.Tier.Singleton.Get(nameof(Data.General.Tier.One)), null) {
            Name.Set(Util.LanguageEnum.Deutsch, "Aura des Willens");
            Name.Set(Util.LanguageEnum.English, "Aura of will");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}