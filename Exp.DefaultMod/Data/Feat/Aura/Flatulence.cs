using Exp.Data.Feat;

namespace Exp.DefaultMod.Feat.Aura {
    internal sealed class Flatulence : FeatDataBase<IAuraData>, IAuraData {
        #region Konstruktor
        internal Flatulence()
            : base(nameof(Flatulence), 900, Api.General.Tier.Singleton.Get(nameof(Data.General.Tier.One)), null) {
            Name.Set(Util.LanguageEnum.Deutsch, "Blähungen");
            Name.Set(Util.LanguageEnum.English, "Flatulence");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}