using Exp.Data.Feat.Offensive;

namespace Exp.DefaultMod.Feat.Offensive {
    public sealed class BetterTwoWeapons : OffensiveDataBase, IOffensiveData {
        #region Konstruktor
        private BetterTwoWeapons()
            : base(nameof(BetterTwoWeapons), 1500, Api.General.Tier.Singleton.Get(nameof(General.Tier.Two)), Api.Feat.Offensive.Singleton.Get(nameof(TwoWeapons))) {
            Name.Set(Util.LanguageEnum.Deutsch, "Besserer Kampf mit zwei Waffen");
            Name.Set(Util.LanguageEnum.English, "Better fight with two weapons");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new BetterTwoWeapons());
        }
        #endregion
    }
}