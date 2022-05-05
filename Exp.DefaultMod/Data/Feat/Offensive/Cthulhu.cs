namespace Exp.DefaultMod.Feat.Offensive {
    public sealed class Cthulhu : Exp.Data.Feat.OffensiveDataBase, Exp.Data.Feat.IOffensiveData {
        #region Konstruktor
        private Cthulhu()
            : base(nameof(Cthulhu), 1800, Api.General.Tier.Singleton.Get(nameof(General.Tier.Three)), null) {
            Name.Set(Util.LanguageEnum.Deutsch, "Cthulhu");
            Name.Set(Util.LanguageEnum.English, "Cthulhu");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new Cthulhu());
        }
        #endregion
    }
}