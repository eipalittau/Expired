using Exp.Data.Feat;
using Exp.Data.General;

namespace Exp.DefaultMod.Feat.Offensive {
    internal sealed class Chaos : FeatDataBase<IOffensiveData>, IOffensiveData {
        #region Konstruktor
        internal Chaos()
            : base(nameof(Chaos), 1900, TierEnum.Three, null) {
            Name.Set(Util.LanguageEnum.Deutsch, "Chaos");
            Name.Set(Util.LanguageEnum.English, "Chaos");
            Description.Set(Util.LanguageEnum.Deutsch, "");
            Description.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}