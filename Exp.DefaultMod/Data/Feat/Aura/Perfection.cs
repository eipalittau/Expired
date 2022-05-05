namespace Exp.DefaultMod.Feat.Aura {
    public sealed class Perfection : Exp.Data.Feat.AuraDataBase, Exp.Data.Feat.IAuraData {
        #region Konstruktor
        private Perfection()
            : base(nameof(Perfection), 1600, Api.General.Tier.Singleton.Get(nameof(General.Tier.Two)), null) {
            Name.Set(Util.LanguageEnum.Deutsch, "Perfektion");
            Name.Set(Util.LanguageEnum.English, "Perfection");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new Perfection());
        }
        #endregion
    }
}