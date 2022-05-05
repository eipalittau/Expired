namespace Exp.DefaultMod.Feat.Aura {
    public sealed class Will : Exp.Data.Feat.AuraDataBase, Exp.Data.Feat.IAuraData {
        #region Konstruktor
        private Will()
            : base(nameof(Will), 500, Api.General.Tier.Singleton.Get(nameof(General.Tier.One)), null) {
            Name.Set(Util.LanguageEnum.Deutsch, "Aura des Willens");
            Name.Set(Util.LanguageEnum.English, "Aura of will");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new Will());
        }
        #endregion
    }
}