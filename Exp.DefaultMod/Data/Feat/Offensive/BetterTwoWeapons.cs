using Exp.Data.Feat;

namespace Exp.DefaultMod.Feat.Offensive {
    internal sealed class BetterTwoWeapons : OffensiveDataBase, IOffensiveData {
        #region Konstruktor
        internal BetterTwoWeapons()
            : base(nameof(BetterTwoWeapons), 1500, Api.General.Tier.Singleton.Get(nameof(General.Tier.Two)), null, Api.Feat.Offensive.Singleton.Get(nameof(TwoWeapons))) {
            Name.Set(Util.LanguageEnum.Deutsch, "Besserer Kampf mit zwei Waffen");
            Name.Set(Util.LanguageEnum.English, "Better fight with two weapons");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}