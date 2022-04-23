using Exp.Data.Feat;
using Exp.Data.General;

namespace Exp.DefaultMod.Feat.Offensive {
    internal sealed class BattleHardened : FeatDataBase<IOffensiveData>, IOffensiveData {
        #region Konstruktor
        internal BattleHardened()
            : base(nameof(BattleHardened), 100, TierEnum.One, null) {
            Name.Set(Util.LanguageEnum.Deutsch, "Kampferprobt");
            Name.Set(Util.LanguageEnum.English, "Battle hardened");
            Description.Set(Util.LanguageEnum.Deutsch, "");
            Description.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}