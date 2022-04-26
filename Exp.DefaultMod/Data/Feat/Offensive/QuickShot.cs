using Exp.Data.Feat;

namespace Exp.DefaultMod.Feat.Offensive {
    internal sealed class QuickShot : FeatDataBase<IOffensiveData>, IOffensiveData {
        #region Konstruktor
        internal QuickShot()
            : base(nameof(QuickShot), 1300, Api.General.Tier.Singleton.Get(nameof(Data.General.Tier.Two)), null) {
            Name.Set(Util.LanguageEnum.Deutsch, "Schnellschuss");
            Name.Set(Util.LanguageEnum.English, "quick shot");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}