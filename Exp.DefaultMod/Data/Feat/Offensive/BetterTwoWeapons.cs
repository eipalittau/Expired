using Exp.Data.Feat;
using Exp.Data.General;

namespace Exp.DefaultMod.Feat.Offensive {
    internal sealed class BetterTwoWeapons : FeatDataBase<IOffensiveData>, IOffensiveData {
        #region Konstruktor
        internal BetterTwoWeapons()
            : base(nameof(BetterTwoWeapons), 1500, TierEnum.Two, null, Api.Feat.Offensive.Singleton.Get("TwoWeapons")) {
            Name.Set(Util.LanguageEnum.Deutsch, "Besserer Kampf mit zwei Waffen");
            Name.Set(Util.LanguageEnum.English, "Better fight with two weapons");
            Description.Set(Util.LanguageEnum.Deutsch, "");
            Description.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}