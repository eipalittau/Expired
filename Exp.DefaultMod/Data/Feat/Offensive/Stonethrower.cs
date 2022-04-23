using Exp.Data.Feat;
using Exp.Data.General;

namespace Exp.DefaultMod.Feat.Offensive {
    internal sealed class Stonethrower : FeatDataBase<IOffensiveData>, IOffensiveData {
        #region Konstruktor
        internal Stonethrower()
            : base(nameof(Stonethrower), 200, TierEnum.One, ActionTypeEnum.Standard) {
            Name.Set(Util.LanguageEnum.Deutsch, "Steinwerfer");
            Name.Set(Util.LanguageEnum.English, "Stone thrower");
            Description.Set(Util.LanguageEnum.Deutsch, "");
            Description.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}