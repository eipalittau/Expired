namespace Exp.DefaultMod.Feat.Offensive {
    public sealed class QuickShot : Exp.Data.Feat.OffensiveDataBase, Exp.Data.Feat.IOffensiveData {
        #region Konstruktor
        private QuickShot()
            : base(nameof(QuickShot), 1300, Api.General.Tier.Singleton.Get(nameof(General.Tier.Two)), null) {
            Name.Set(Util.LanguageEnum.Deutsch, "Schnellschuss");
            Name.Set(Util.LanguageEnum.English, "quick shot");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new QuickShot());
        }
        #endregion
    }
}