namespace Exp.DefaultMod.Feat.Defensive {
    public sealed class RoadRunner : Exp.Data.Feat.DefensiveDataBase, Exp.Data.Feat.IDefensiveData {
        #region Konstruktor
        private RoadRunner()
            : base(nameof(RoadRunner), 1500, Api.General.Tier.Singleton.Get(nameof(General.Tier.Two)), null) {
            Name.Set(Util.LanguageEnum.Deutsch, "Road runner");
            Name.Set(Util.LanguageEnum.English, "Straßenläufer");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new RoadRunner());
        }
        #endregion
    }
}