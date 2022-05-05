namespace Exp.DefaultMod.Feat.Defensive {
    public sealed class Hephaistos : Exp.Data.Feat.DefensiveDataBase, Exp.Data.Feat.IDefensiveData {
        #region Konstruktor
        private Hephaistos()
            : base(nameof(Hephaistos), 1700, Api.General.Tier.Singleton.Get(nameof(General.Tier.Three)), null) {
            Name.Set(Util.LanguageEnum.Deutsch, "Hephaistos");
            Name.Set(Util.LanguageEnum.English, "Hephaistos");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new Hephaistos());
        }
        #endregion
    }
}