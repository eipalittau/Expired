namespace Exp.DefaultMod.Feat.Aura {
    public sealed class Coordinated : Exp.Data.Feat.AuraDataBase, Exp.Data.Feat.IAuraData {
        #region Konstruktor
        private Coordinated()
            : base(nameof(Coordinated), 1200, Api.General.Tier.Singleton.Get(nameof(General.Tier.One)), null) {
            Name.Set(Util.LanguageEnum.Deutsch, "Koordiniert");
            Name.Set(Util.LanguageEnum.English, "Coordinated");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new Coordinated());
        }
        #endregion
    }
}