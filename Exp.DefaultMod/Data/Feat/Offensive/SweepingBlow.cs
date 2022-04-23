using Exp.Data.Feat;
using Exp.Data.General;

namespace Exp.DefaultMod.Feat.Offensive {
    internal sealed class SweepingBlow : FeatDataBase<IOffensiveData>, IOffensiveData {
        #region Konstruktor
        internal SweepingBlow()
            : base(nameof(SweepingBlow), 500, TierEnum.One, ActionTypeEnum.Standard) {
            Name.Set(Util.LanguageEnum.Deutsch, "Rundumschlag");
            Name.Set(Util.LanguageEnum.English, "Sweeping blow");
            Description.Set(Util.LanguageEnum.Deutsch, "");
            Description.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}