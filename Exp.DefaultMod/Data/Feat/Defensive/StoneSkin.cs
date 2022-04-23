using Exp.Data.Feat;
using Exp.Data.General;

namespace Exp.DefaultMod.Feat.Defensive {
    internal sealed class StoneSkin : FeatDataBase<IDefensiveData>, IDefensiveData {
        #region Konstruktor
        internal StoneSkin()
            : base(nameof(StoneSkin), 1200, TierEnum.Two, null) {
            Name.Set(Util.LanguageEnum.Deutsch, "Steinhaut");
            Name.Set(Util.LanguageEnum.English, "Stone skin");
            Description.Set(Util.LanguageEnum.Deutsch, "");
            Description.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}