namespace Exp.DefaultMod.Feat.Aura {
    public sealed class Masochist : Exp.Data.Feat.AuraDataBase, Exp.Data.Feat.IAuraData {
        #region Konstruktor
        private Masochist()
            : base(nameof(Masochist), 1500, Api.General.Tier.Singleton.Get(nameof(General.Tier.One)), null) {
            Name.Set(Util.LanguageEnum.Deutsch, "Masochist");
            Name.Set(Util.LanguageEnum.English, "Masochist");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new Masochist());
        }
        #endregion
    }
}