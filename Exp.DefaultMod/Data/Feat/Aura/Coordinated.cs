using Exp.Data.Feat;
using Exp.Data.General;

namespace Exp.DefaultMod.Feat.Aura {
    internal sealed class Coordinated : AuraDataBase, IAuraData {
        #region Konstruktor
        internal Coordinated()
            : base(nameof(Coordinated), 1200, Api.General.Tier.Singleton.Get(nameof(General.Tier.One)), null) {
            Name.Set(Util.LanguageEnum.Deutsch, "Koordiniert");
            Name.Set(Util.LanguageEnum.English, "Coordinated");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}