using Exp.Data.Feat;
using Exp.Data.General;

namespace Exp.DefaultMod.Feat.Offensive {
    internal sealed class Cthulhu : FeatDataBase<IOffensiveData>, IOffensiveData {
        #region Konstruktor
        internal Cthulhu()
            : base(nameof(Cthulhu), 1800, TierEnum.Three, null) {
            Name.Set(Util.LanguageEnum.Deutsch, "Cthulhu");
            Name.Set(Util.LanguageEnum.English, "Cthulhu");
            Description.Set(Util.LanguageEnum.Deutsch, "");
            Description.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}