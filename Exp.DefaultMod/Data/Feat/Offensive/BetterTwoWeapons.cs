using Exp.Data.Feat.Offensive;
using Exp.Util.Enumeration;

namespace Exp.DefaultMod.Feat.Offensive
{
    public sealed class BetterTwoWeapons : OffensiveDataBase, IOffensiveData {
        #region Konstruktor
        private BetterTwoWeapons()
            : base(nameof(BetterTwoWeapons), 1500, Api.General.Tier.Singleton.Get(nameof(General.Tier.Two)), Api.Feat.Offensive.Singleton.Get(nameof(TwoWeapons))) {
            Name.Set(LanguageEnum.Deutsch, "Besserer Kampf mit zwei Waffen");
            Name.Set(LanguageEnum.English, "Better fight with two weapons");
            LoreDescription.Set(LanguageEnum.Deutsch, "");
            LoreDescription.Set(LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new BetterTwoWeapons());
        }
        #endregion
    }
}