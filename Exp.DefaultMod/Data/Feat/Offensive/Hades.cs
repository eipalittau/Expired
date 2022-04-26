using Exp.Data.Feat;

namespace Exp.DefaultMod.Feat.Offensive {
    internal sealed class Hades : FeatDataBase<IOffensiveData>, IOffensiveData {
        #region Konstruktor
        internal Hades()
            : base(nameof(Hades), 2000, Api.General.Tier.Singleton.Get(nameof(Data.General.Tier.Three)), null) {
            Name.Set(Util.LanguageEnum.Deutsch, "Hades");
            Name.Set(Util.LanguageEnum.English, "Hades");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}