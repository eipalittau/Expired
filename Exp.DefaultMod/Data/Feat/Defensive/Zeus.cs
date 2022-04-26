using Exp.Data.Feat;

namespace Exp.DefaultMod.Feat.Defensive {
    internal sealed class Zeus : FeatDataBase<IDefensiveData>, IDefensiveData {
        #region Konstruktor
        internal Zeus()
            : base(nameof(Zeus), 1800, Api.General.Tier.Singleton.Get(nameof(Data.General.Tier.Three)), null) {
            Name.Set(Util.LanguageEnum.Deutsch, "Zeus");
            Name.Set(Util.LanguageEnum.English, "Zeus");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}