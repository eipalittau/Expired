using Exp.Data.Feat;

namespace Exp.DefaultMod.Feat.Aura {
    internal sealed class Agile : AuraDataBase, IAuraData {
        #region Konstruktor
        internal Agile()
            : base(nameof(Agile), 1100, Api.General.Tier.Singleton.Get(nameof(General.Tier.One)), null) {
            Name.Set(Util.LanguageEnum.Deutsch, "Geschickt");
            Name.Set(Util.LanguageEnum.English, "Agile");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}