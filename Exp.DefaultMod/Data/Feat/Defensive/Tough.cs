namespace Exp.DefaultMod.Feat.Defensive {
    public sealed class Tough : Exp.Data.Feat.DefensiveDataBase, Exp.Data.Feat.IDefensiveData {
        #region Konstruktor
        private Tough()
            : base(nameof(Tough), 200, Api.General.Tier.Singleton.Get(nameof(General.Tier.One)), null) {
            Name.Set(Util.LanguageEnum.Deutsch, "Zäh");
            Name.Set(Util.LanguageEnum.English, "Tough");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new Tough());
        }
        #endregion
    }
}