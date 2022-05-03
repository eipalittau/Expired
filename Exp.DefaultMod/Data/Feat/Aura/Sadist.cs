using Exp.Data.Feat;

namespace Exp.DefaultMod.Feat.Aura {
    internal sealed class Sadist : AuraDataBase, IAuraData {
        #region Konstruktor
        internal Sadist()
            : base(nameof(Sadist), 1400, Api.General.Tier.Singleton.Get(nameof(General.Tier.One)), null) {
            Name.Set(Util.LanguageEnum.Deutsch, "Sadist");
            Name.Set(Util.LanguageEnum.English, "Sadist");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}