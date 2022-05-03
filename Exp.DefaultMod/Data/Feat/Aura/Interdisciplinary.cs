using Exp.Data.Feat;

namespace Exp.DefaultMod.Feat.Aura {
    internal sealed class Interdisciplinary : AuraDataBase, IAuraData {
        #region Konstruktor
        internal Interdisciplinary()
            : base(nameof(Interdisciplinary), 1700, Api.General.Tier.Singleton.Get(nameof(General.Tier.Two)), null) {
            Name.Set(Util.LanguageEnum.Deutsch, "Interdisziplinär");
            Name.Set(Util.LanguageEnum.English, "Interdisciplinary");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}