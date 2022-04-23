using Exp.Data.Feat;
using Exp.Data.General;

namespace Exp.DefaultMod.Feat.Offensive {
    internal sealed class ThornSkin : FeatDataBase<IOffensiveData>, IOffensiveData {
        #region Konstruktor
        internal ThornSkin()
            : base(nameof(ThornSkin), 1700, TierEnum.Two, null) {
            Name.Set(Util.LanguageEnum.Deutsch, "Dornenhaut");
            Name.Set(Util.LanguageEnum.English, "Thorn skin");
            Description.Set(Util.LanguageEnum.Deutsch, "");
            Description.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}