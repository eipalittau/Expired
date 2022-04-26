using Exp.Data.Feat;
using Exp.Data.General;

namespace Exp.DefaultMod.Feat.Aura {
    internal sealed class Defense : FeatDataBase<IAuraData>, IAuraData {
        #region Konstruktor
        internal Defense()
            : base(nameof(Defense), 300, Api.General.Tier.Singleton.Get(nameof(Data.General.Tier.One)), null) {
            Name.Set(Util.LanguageEnum.Deutsch, "Aura der Verteidigung");
            Name.Set(Util.LanguageEnum.English, "Aura of defense");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}