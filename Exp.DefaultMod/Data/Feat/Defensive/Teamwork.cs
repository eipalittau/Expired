using Exp.Data.Feat;
using Exp.Data.General;

namespace Exp.DefaultMod.Feat.Defensive {
    internal sealed class Teamwork : FeatDataBase<IDefensiveData>, IDefensiveData {
        #region Konstruktor
        internal Teamwork()
            : base(nameof(Teamwork), 1100, TierEnum.Two, null, Api.Feat.Defensive.Singleton.Get("Teamplayer")) {
            Name.Set(Util.LanguageEnum.Deutsch, "Teamwork");
            Name.Set(Util.LanguageEnum.English, "Teamwork");
            Description.Set(Util.LanguageEnum.Deutsch, "");
            Description.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}