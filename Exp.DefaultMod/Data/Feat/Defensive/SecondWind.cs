using Exp.Data.Feat.Defensive;
using Exp.Util.Enumeration;

namespace Exp.DefaultMod.Feat.Defensive
{
    public sealed class SecondWind : DefensiveDataBase, IDefensiveData {
        #region Konstruktor
        private SecondWind()
            : base(nameof(SecondWind), 1000, Api.General.Tier.Singleton.Get(nameof(General.Tier.Two)), Api.General.ActionType.Singleton.Get(nameof(General.ActionType.Standard))) {
            Name.Set(LanguageEnum.Deutsch, "Zweiter Wind");
            Name.Set(LanguageEnum.English, "Second wind");
            LoreDescription.Set(LanguageEnum.Deutsch, "");
            LoreDescription.Set(LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new SecondWind());
        }
        #endregion
    }
}