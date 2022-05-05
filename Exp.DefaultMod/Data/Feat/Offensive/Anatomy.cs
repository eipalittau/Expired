namespace Exp.DefaultMod.Feat.Offensive {
    public sealed class Anatomy : Exp.Data.Feat.OffensiveDataBase, Exp.Data.Feat.IOffensiveData {
        #region Konstruktor
        private Anatomy()
            : base(nameof(Anatomy), 1400, Api.General.Tier.Singleton.Get(nameof(General.Tier.Two)), null) {
            Name.Set(Util.LanguageEnum.Deutsch, "Anatomie");
            Name.Set(Util.LanguageEnum.English, "Anatomy");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new Anatomy());
        }
        #endregion
    }
}