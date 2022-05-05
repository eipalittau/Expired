namespace Exp.DefaultMod.Feat.Aura {
    public sealed class Reflexes : Exp.Data.Feat.AuraDataBase, Exp.Data.Feat.IAuraData {
        #region Konstruktor
        private Reflexes()
            : base(nameof(Reflexes), 400, Api.General.Tier.Singleton.Get(nameof(General.Tier.One)), null) {
            Name.Set(Util.LanguageEnum.Deutsch, "Aura der Reflexe");
            Name.Set(Util.LanguageEnum.English, "Aura of reflexes");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new Reflexes());
        }
        #endregion
    }
}