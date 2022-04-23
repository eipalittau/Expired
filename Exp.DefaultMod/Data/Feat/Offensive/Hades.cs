using Exp.Data.Feat;
using Exp.Data.General;

namespace Exp.DefaultMod.Feat.Offensive {
    internal sealed class Hades : FeatDataBase<IOffensiveData>, IOffensiveData {
        #region Konstruktor
        internal Hades()
            : base(nameof(Hades), 2000, TierEnum.Three, null) {
            Name.Set(Util.LanguageEnum.Deutsch, "Hades");
            Name.Set(Util.LanguageEnum.English, "Hades");
            Description.Set(Util.LanguageEnum.Deutsch, "");
            Description.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}