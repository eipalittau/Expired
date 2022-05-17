using Exp.Data.Feat.Defensive;

namespace Exp.DefaultMod.Feat.Defensive {
    public sealed class SecondWind : DefensiveDataBase, IDefensiveData {
        #region Konstruktor
        private SecondWind()
            : base(nameof(SecondWind), 1000, Api.General.Tier.Singleton.Get(nameof(General.Tier.Two)), Api.General.ActionType.Singleton.Get(nameof(General.ActionType.Standard))) {
            Name.Set(Util.LanguageEnum.Deutsch, "Zweiter Wind");
            Name.Set(Util.LanguageEnum.English, "Second wind");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new SecondWind());
        }
        #endregion
    }
}