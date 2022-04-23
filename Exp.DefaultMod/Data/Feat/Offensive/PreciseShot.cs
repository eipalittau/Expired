using Exp.Data.Feat;
using Exp.Data.General;

namespace Exp.DefaultMod.Feat.Offensive {
    internal sealed class PreciseShot : FeatDataBase<IOffensiveData>, IOffensiveData {
        #region Konstruktor
        internal PreciseShot()
            : base(nameof(PreciseShot), 400, TierEnum.One, null) {
            Name.Set(Util.LanguageEnum.Deutsch, "Präziser Schuss");
            Name.Set(Util.LanguageEnum.English, "Precise shot");
            Description.Set(Util.LanguageEnum.Deutsch, "");
            Description.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}