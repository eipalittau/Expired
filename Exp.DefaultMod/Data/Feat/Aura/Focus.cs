using Exp.Data.Feat;

namespace Exp.DefaultMod.Feat.Aura {
    internal sealed class Focus : FeatDataBase<IAuraData>, IAuraData {
        #region Konstruktor
        internal Focus()
            : base(nameof(Focus), 700, Api.General.Tier.Singleton.Get(nameof(Data.General.Tier.One)), null) {
            Name.Set(Util.LanguageEnum.Deutsch, "Fokus");
            Name.Set(Util.LanguageEnum.English, "Focus");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}