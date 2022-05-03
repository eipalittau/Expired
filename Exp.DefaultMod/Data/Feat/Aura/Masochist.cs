using Exp.Data.Feat;

namespace Exp.DefaultMod.Feat.Aura {
    internal sealed class Masochist : AuraDataBase, IAuraData {
        #region Konstruktor
        internal Masochist()
            : base(nameof(Masochist), 1500, Api.General.Tier.Singleton.Get(nameof(General.Tier.One)), null) {
            Name.Set(Util.LanguageEnum.Deutsch, "Masochist");
            Name.Set(Util.LanguageEnum.English, "Masochist");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}