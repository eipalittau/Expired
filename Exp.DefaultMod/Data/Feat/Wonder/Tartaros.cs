namespace Exp.DefaultMod.Feat.Wonder {
    public sealed class Tartaros : Exp.Data.Feat.WonderDataBase, Exp.Data.Feat.IWonderData {
        #region Konstruktor
        private Tartaros()
            : base(nameof(Tartaros), 1600, Api.General.Tier.Singleton.Get(nameof(General.Tier.Three))) {
            Name.Set(Util.LanguageEnum.Deutsch, "Tartaros");
            Name.Set(Util.LanguageEnum.English, "Tartaros");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new Tartaros());
        }
        #endregion
    }
}