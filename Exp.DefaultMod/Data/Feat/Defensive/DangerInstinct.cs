namespace Exp.DefaultMod.Feat.Defensive {
    public sealed class DangerInstinct : Exp.Data.Feat.DefensiveDataBase, Exp.Data.Feat.IDefensiveData {
        #region Konstruktor
        private DangerInstinct()
            : base(nameof(DangerInstinct), 400, Api.General.Tier.Singleton.Get(nameof(General.Tier.One)), null) {
            Name.Set(Util.LanguageEnum.Deutsch, "Gefahreninstinkt");
            Name.Set(Util.LanguageEnum.English, "Danger instinct");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new DangerInstinct());
        }
        #endregion
    }
}