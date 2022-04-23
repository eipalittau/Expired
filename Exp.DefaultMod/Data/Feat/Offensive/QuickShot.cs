using Exp.Data.Feat;
using Exp.Data.General;

namespace Exp.DefaultMod.Feat.Offensive {
    internal sealed class QuickShot : FeatDataBase<IOffensiveData>, IOffensiveData {
        #region Konstruktor
        internal QuickShot()
            : base(nameof(QuickShot), 1300, TierEnum.Two, null) {
            Name.Set(Util.LanguageEnum.Deutsch, "Schnellschuss");
            Name.Set(Util.LanguageEnum.English, "quick shot");
            Description.Set(Util.LanguageEnum.Deutsch, "");
            Description.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}