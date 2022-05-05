namespace Exp.DefaultMod.Feat.Offensive {
    public sealed class Teamplayer : Exp.Data.Feat.OffensiveDataBase, Exp.Data.Feat.IOffensiveData {
        #region Konstruktor
        private Teamplayer()
            : base(nameof(Teamplayer), 700, Api.General.Tier.Singleton.Get(nameof(General.Tier.One)), null) {
            Name.Set(Util.LanguageEnum.Deutsch, "Teamplayer");
            Name.Set(Util.LanguageEnum.English, "Teamplayer");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new Teamplayer());
        }
        #endregion
    }
}