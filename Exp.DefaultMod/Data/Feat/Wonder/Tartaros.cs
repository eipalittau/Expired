using Exp.Data.Feat;

namespace Exp.DefaultMod.Feat.Wonder {
    internal sealed class Tartaros : FeatDataBase<IWonderData>, IWonderData {
        #region Konstruktor
        internal Tartaros()
            : base(nameof(Tartaros), 1600, Api.General.Tier.Singleton.Get(nameof(Data.General.Tier.Three)), null) {
            Name.Set(Util.LanguageEnum.Deutsch, "Tartaros");
            Name.Set(Util.LanguageEnum.English, "Tartaros");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}