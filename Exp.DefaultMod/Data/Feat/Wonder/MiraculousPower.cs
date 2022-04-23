using Exp.Data.Feat;
using Exp.Data.General;

namespace Exp.DefaultMod.Feat.Wonder {
    internal sealed class MiraculousPower : FeatDataBase<IWonderData>, IWonderData {
        #region Konstruktor
        internal MiraculousPower()
            : base(nameof(MiraculousPower), 800, TierEnum.One, null) {
            Name.Set(Util.LanguageEnum.Deutsch, "Wundermacht");
            Name.Set(Util.LanguageEnum.English, "Miraculous power");
            Description.Set(Util.LanguageEnum.Deutsch, "");
            Description.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}