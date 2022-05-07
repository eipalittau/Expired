namespace Exp.DefaultMod.Feat.Aura {
    public sealed class Focus : Exp.Data.Feat.AuraDataBase, Exp.Data.Feat.IAuraData {
        #region Konstruktor
        private Focus()
            : base(nameof(Focus), 700, Api.General.Tier.Singleton.Get(nameof(General.Tier.One)), null) {
            Name.Set(Util.LanguageEnum.Deutsch, "Fokus");
            Name.Set(Util.LanguageEnum.English, "Focus");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new Focus());
        }
        #endregion
    }
}