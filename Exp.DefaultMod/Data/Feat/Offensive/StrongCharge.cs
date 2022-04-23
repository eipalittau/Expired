using Exp.Data.Feat;
using Exp.Data.General;

namespace Exp.DefaultMod.Feat.Offensive {
    internal sealed class StrongCharge : FeatDataBase<IOffensiveData>, IOffensiveData {
        #region Konstruktor
        internal StrongCharge()
            : base(nameof(StrongCharge), 900, TierEnum.One, ActionTypeEnum.Full) {
            Name.Set(Util.LanguageEnum.Deutsch, "CHAAAARGE!!!");
            Name.Set(Util.LanguageEnum.English, "CHAAAARGE!!!");
            Description.Set(Util.LanguageEnum.Deutsch, "");
            Description.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}