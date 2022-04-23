using Exp.Data.Feat;
using Exp.Data.General;

namespace Exp.DefaultMod.Feat.Offensive {
    internal sealed class TwoWeapons : FeatDataBase<IOffensiveData>, IOffensiveData {
        #region Konstruktor
        internal TwoWeapons()
            : base(nameof(TwoWeapons), 800, TierEnum.One, null) {
            Name.Set(Util.LanguageEnum.Deutsch, "Kampf mit zwei Waffen");
            Name.Set(Util.LanguageEnum.English, "Fight with two weapons");
            Description.Set(Util.LanguageEnum.Deutsch, "");
            Description.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}