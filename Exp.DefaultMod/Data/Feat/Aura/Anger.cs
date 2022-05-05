namespace Exp.DefaultMod.Feat.Aura {
    public sealed class Anger : Exp.Data.Feat.AuraDataBase, Exp.Data.Feat.IAuraData {
        #region Konstruktor
        private Anger()
            : base(nameof(Anger), 600, Api.General.Tier.Singleton.Get(nameof(General.Tier.One)), null, Api.Feat.Aura.Singleton.Get(nameof(Fencer)), Api.Feat.Aura.Singleton.Get(nameof(Power))) {
            Name.Set(Util.LanguageEnum.Deutsch, "Aura des Zorns");
            Name.Set(Util.LanguageEnum.English, "Aura of anger");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new Anger());
        }
        #endregion
    }
}