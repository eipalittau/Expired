using Exp.Data.Feat;

namespace Exp.DefaultMod.Feat.Aura {
    internal sealed class Fencer : AuraDataBase, IAuraData {
        #region Konstruktor
        internal Fencer()
            : base(nameof(Fencer), 100, Api.General.Tier.Singleton.Get(nameof(General.Tier.One)), null) {
            Name.Set(Util.LanguageEnum.Deutsch, "Aura des Fechters");
            Name.Set(Util.LanguageEnum.English, "Aura of the fencer");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}