using Exp.Data.Feat;
using Exp.Data.General;

namespace Exp.DefaultMod.Feat.Wonder {
    internal sealed class MiraculousPower2 : FeatDataBase<IWonderData>, IWonderData {
        #region Konstruktor
        internal MiraculousPower2()
            : base(nameof(MiraculousPower2), 1500, TierEnum.Two, null, Api.Feat.Wonder.Singleton.Get("MiraculousPower")) {
            Name.Set(Util.LanguageEnum.Deutsch, "Wundermacht++");
            Name.Set(Util.LanguageEnum.English, "Miraculous power++");
            Description.Set(Util.LanguageEnum.Deutsch, "");
            Description.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}