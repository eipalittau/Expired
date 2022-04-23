using Exp.Data.Feat;
using Exp.Data.General;

namespace Exp.DefaultMod.Feat.Offensive {
    internal sealed class Teamwork : FeatDataBase<IOffensiveData>, IOffensiveData {
        #region Konstruktor
        internal Teamwork()
            : base(nameof(Teamwork), 1000, TierEnum.Two, null, Api.Feat.Offensive.Singleton.Get("Teamplayer")) {
            Name.Set(Util.LanguageEnum.Deutsch, "Teamwork");
            Name.Set(Util.LanguageEnum.English, "Teamwork");
            Description.Set(Util.LanguageEnum.Deutsch, "");
            Description.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}