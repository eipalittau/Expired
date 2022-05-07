namespace Exp.DefaultMod.Feat.Wonder {
    public sealed class Lubricate : Exp.Data.Feat.WonderDataBase, Exp.Data.Feat.IWonderData {
        #region Konstruktor
        private Lubricate()
            : base(nameof(Lubricate), 600, Api.General.Tier.Singleton.Get(nameof(General.Tier.One)), Api.General.ActionType.Singleton.Get(nameof(General.ActionType.Standard))) {
            Name.Set(Util.LanguageEnum.Deutsch, "Schmieren");
            Name.Set(Util.LanguageEnum.English, "Lubricate");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new Lubricate());
        }
        #endregion
    }
}