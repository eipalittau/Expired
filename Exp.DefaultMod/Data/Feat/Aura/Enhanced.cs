namespace Exp.DefaultMod.Feat.Aura {
    public sealed class Enhanced : Exp.Data.Feat.AuraDataBase, Exp.Data.Feat.IAuraData {
        #region Konstruktor
        private Enhanced()
            : base(nameof(Enhanced), 800, Api.General.Tier.Singleton.Get(nameof(General.Tier.One)), null) {
            Name.Set(Util.LanguageEnum.Deutsch, "Verstärkte Aura");
            Name.Set(Util.LanguageEnum.English, "Enhanced aura");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new Enhanced());
        }
        #endregion
    }
}