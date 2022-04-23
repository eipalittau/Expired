using Exp.Data.Feat;
using Exp.Data.General;

namespace Exp.DefaultMod.Feat.Defensive {
    internal sealed class Teamplayer : FeatDataBase<IDefensiveData>, IDefensiveData {
        #region Konstruktor
        internal Teamplayer()
            : base(nameof(Teamplayer), 700, TierEnum.One, null) {
            Name.Set(Util.LanguageEnum.Deutsch, "Teamplayer");
            Name.Set(Util.LanguageEnum.English, "Teamplayer");
            Description.Set(Util.LanguageEnum.Deutsch, "");
            Description.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}