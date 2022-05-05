namespace Exp.DefaultMod.Feat.Offensive {
    public sealed class TwoWeapons : Exp.Data.Feat.OffensiveDataBase, Exp.Data.Feat.IOffensiveData {
        #region Konstruktor
        private TwoWeapons()
            : base(nameof(TwoWeapons), 800, Api.General.Tier.Singleton.Get(nameof(General.Tier.One)), null) {
            Name.Set(Util.LanguageEnum.Deutsch, "Kampf mit zwei Waffen");
            Name.Set(Util.LanguageEnum.English, "Fight with two weapons");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new TwoWeapons());
        }
        #endregion
    }
}