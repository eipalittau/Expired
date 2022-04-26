using Exp.Data.Feat;

namespace Exp.DefaultMod.Feat.Wonder {
    internal sealed class Nyx : FeatDataBase<IWonderData>, IWonderData {
        #region Konstruktor
        internal Nyx()
            : base(nameof(Nyx), 1700, Api.General.Tier.Singleton.Get(nameof(Data.General.Tier.Three)), null) {
            Name.Set(Util.LanguageEnum.Deutsch, "Nyx");
            Name.Set(Util.LanguageEnum.English, "Nyx");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}