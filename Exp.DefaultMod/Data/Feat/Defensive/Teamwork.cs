namespace Exp.DefaultMod.Feat.Defensive {
    public sealed class Teamwork : Exp.Data.Feat.DefensiveDataBase, Exp.Data.Feat.IDefensiveData {
        #region Konstruktor
        private Teamwork()
            : base(nameof(Teamwork), 1100, Api.General.Tier.Singleton.Get(nameof(General.Tier.Two)), null, Api.Feat.Defensive.Singleton.Get(nameof(Teamplayer))) {
            Name.Set(Util.LanguageEnum.Deutsch, "Teamwork");
            Name.Set(Util.LanguageEnum.English, "Teamwork");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new Teamwork());
        }
        #endregion
    }
}