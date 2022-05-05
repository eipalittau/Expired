namespace Exp.DefaultMod.Feat.Offensive {
    public sealed class Riposte : Exp.Data.Feat.OffensiveDataBase, Exp.Data.Feat.IOffensiveData {
        #region Konstruktor
        private Riposte()
            : base(nameof(Riposte), 1600, Api.General.Tier.Singleton.Get(nameof(General.Tier.Two)), null) {
            Name.Set(Util.LanguageEnum.Deutsch, "Antworten");
            Name.Set(Util.LanguageEnum.English, "Riposte");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new Riposte());
        }
        #endregion
    }
}