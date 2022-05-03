using Exp.Data.Feat;

namespace Exp.DefaultMod.Feat.Aura {
    internal sealed class Perfection : AuraDataBase, IAuraData {
        #region Konstruktor
        internal Perfection()
            : base(nameof(Perfection), 1600, Api.General.Tier.Singleton.Get(nameof(General.Tier.Two)), null) {
            Name.Set(Util.LanguageEnum.Deutsch, "Perfektion");
            Name.Set(Util.LanguageEnum.English, "Perfection");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}