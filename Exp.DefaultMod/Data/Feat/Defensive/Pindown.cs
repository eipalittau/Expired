namespace Exp.DefaultMod.Feat.Defensive {
    public sealed class Pindown : Exp.Data.Feat.DefensiveDataBase, Exp.Data.Feat.IDefensiveData {
        #region Konstruktor
        private Pindown()
            : base(nameof(Pindown), 800, Api.General.Tier.Singleton.Get(nameof(General.Tier.One)), null) {
            Name.Set(Util.LanguageEnum.Deutsch, "Anpinnen");
            Name.Set(Util.LanguageEnum.English, "Pindown");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new Pindown());
        }
        #endregion
    }
}