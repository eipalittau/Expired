using Exp.Data.Feat;

namespace Exp.DefaultMod.Feat.Aura {
    internal sealed class Reflexes : AuraDataBase, IAuraData {
        #region Konstruktor
        internal Reflexes()
            : base(nameof(Reflexes), 400, Api.General.Tier.Singleton.Get(nameof(General.Tier.One)), null) {
            Name.Set(Util.LanguageEnum.Deutsch, "Aura der Reflexe");
            Name.Set(Util.LanguageEnum.English, "Aura of reflexes");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}