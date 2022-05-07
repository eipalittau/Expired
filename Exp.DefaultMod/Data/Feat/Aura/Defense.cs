namespace Exp.DefaultMod.Feat.Aura {
    public sealed class Defense : Exp.Data.Feat.AuraDataBase, Exp.Data.Feat.IAuraData {
        #region Konstruktor
        private Defense()
            : base(nameof(Defense), 300, Api.General.Tier.Singleton.Get(nameof(General.Tier.One)), null) {
            Name.Set(Util.LanguageEnum.Deutsch, "Aura der Verteidigung");
            Name.Set(Util.LanguageEnum.English, "Aura of defense");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new Defense());
        }
        #endregion
    }
}