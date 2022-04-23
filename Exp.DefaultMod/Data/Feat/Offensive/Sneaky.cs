using Exp.Data.Feat;
using Exp.Data.General;

namespace Exp.DefaultMod.Feat.Offensive {
    internal sealed class Sneaky : FeatDataBase<IOffensiveData>, IOffensiveData {
        #region Konstruktor
        internal Sneaky()
            : base(nameof(Sneaky), 1200, TierEnum.Two, ActionTypeEnum.Standard) {
            Name.Set(Util.LanguageEnum.Deutsch, "Hinterhältig");
            Name.Set(Util.LanguageEnum.English, "Sneaky");
            Description.Set(Util.LanguageEnum.Deutsch, "");
            Description.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}