namespace Exp.DefaultMod.Feat.Offensive {
    public sealed class PreciseShot : Exp.Data.Feat.OffensiveDataBase, Exp.Data.Feat.IOffensiveData {
        #region Konstruktor
        private PreciseShot()
            : base(nameof(PreciseShot), 400, Api.General.Tier.Singleton.Get(nameof(General.Tier.One)), null) {
            Name.Set(Util.LanguageEnum.Deutsch, "Präziser Schuss");
            Name.Set(Util.LanguageEnum.English, "Precise shot");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new PreciseShot());
        }
        #endregion
    }
}