namespace Exp.DefaultMod.Feat.Defensive {
    public sealed class Zeus : Exp.Data.Feat.DefensiveDataBase, Exp.Data.Feat.IDefensiveData {
        #region Konstruktor
        private Zeus()
            : base(nameof(Zeus), 1800, Api.General.Tier.Singleton.Get(nameof(General.Tier.Three)), null) {
            Name.Set(Util.LanguageEnum.Deutsch, "Zeus");
            Name.Set(Util.LanguageEnum.English, "Zeus");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new Zeus());
        }
        #endregion
    }
}