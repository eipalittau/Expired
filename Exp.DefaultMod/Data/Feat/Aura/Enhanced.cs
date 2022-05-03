using Exp.Data.Feat;
using Exp.Data.General;

namespace Exp.DefaultMod.Feat.Aura {
    internal sealed class Enhanced : AuraDataBase, IAuraData {
        #region Konstruktor
        internal Enhanced()
            : base(nameof(Enhanced), 800, Api.General.Tier.Singleton.Get(nameof(General.Tier.One)), null) {
            Name.Set(Util.LanguageEnum.Deutsch, "Verstärkte Aura");
            Name.Set(Util.LanguageEnum.English, "Enhanced aura");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}