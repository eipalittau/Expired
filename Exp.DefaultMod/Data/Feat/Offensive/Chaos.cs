namespace Exp.DefaultMod.Feat.Offensive {
    public sealed class Chaos : Exp.Data.Feat.OffensiveDataBase, Exp.Data.Feat.IOffensiveData {
        #region Konstruktor
        private Chaos()
            : base(nameof(Chaos), 1900, Api.General.Tier.Singleton.Get(nameof(General.Tier.Three)), null) {
            Name.Set(Util.LanguageEnum.Deutsch, "Chaos");
            Name.Set(Util.LanguageEnum.English, "Chaos");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new Chaos());
        }
        #endregion
    }
}