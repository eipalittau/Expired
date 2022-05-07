namespace Exp.DefaultMod.Feat.Defensive {
    public sealed class Agile : Exp.Data.Feat.DefensiveDataBase, Exp.Data.Feat.IDefensiveData {
        #region Konstruktor
        private Agile()
            : base(nameof(Agile), 600, Api.General.Tier.Singleton.Get(nameof(General.Tier.One)), null) {
            Name.Set(Util.LanguageEnum.Deutsch, "Agil");
            Name.Set(Util.LanguageEnum.English, "Agile");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new Agile());
        }
        #endregion
    }
}