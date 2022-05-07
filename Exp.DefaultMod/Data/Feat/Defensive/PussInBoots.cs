namespace Exp.DefaultMod.Feat.Defensive {
    public sealed class PussInBoots : Exp.Data.Feat.DefensiveDataBase, Exp.Data.Feat.IDefensiveData {
        #region Konstruktor
        private PussInBoots()
            : base(nameof(PussInBoots), 1400, Api.General.Tier.Singleton.Get(nameof(General.Tier.Two)), null) {
            Name.Set(Util.LanguageEnum.Deutsch, "Der gestiefelte Kater");
            Name.Set(Util.LanguageEnum.English, "Puss in boots");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new PussInBoots());
        }
        #endregion
    }
}