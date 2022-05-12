namespace Exp.DefaultMod.Feat.Aura {
    public sealed class Agile : Data.Feat.AuraDataBase, Data.Feat.IAuraData {
        #region Konstruktor
        private Agile()
            : base(nameof(Agile), 1100, Api.General.Tier.Singleton.Get(nameof(General.Tier.One)), null) {
            Name.Set(Util.LanguageEnum.Deutsch, "Geschickt");
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