using Exp.Data.Feat;

namespace Exp.DefaultMod.Feat.Offensive {
    internal sealed class Teamwork : FeatDataBase<IOffensiveData>, IOffensiveData {
        #region Konstruktor
        internal Teamwork()
            : base(nameof(Teamwork), 1000, Api.General.Tier.Singleton.Get(nameof(Data.General.Tier.Two)), null, Api.Feat.Offensive.Singleton.Get(nameof(Teamplayer))) {
            Name.Set(Util.LanguageEnum.Deutsch, "Teamwork");
            Name.Set(Util.LanguageEnum.English, "Teamwork");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}