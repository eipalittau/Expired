namespace Exp.DefaultMod.Feat.Offensive {
    public sealed class Sneaky : Exp.Data.Feat.OffensiveDataBase, Exp.Data.Feat.IOffensiveData {
        #region Konstruktor
        private Sneaky()
            : base(nameof(Sneaky), 1200, Api.General.Tier.Singleton.Get(nameof(General.Tier.Two)), Api.General.ActionType.Singleton.Get(nameof(General.ActionType.Standard))) {
            Name.Set(Util.LanguageEnum.Deutsch, "Hinterhältig");
            Name.Set(Util.LanguageEnum.English, "Sneaky");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new Sneaky());
        }
        #endregion
    }
}