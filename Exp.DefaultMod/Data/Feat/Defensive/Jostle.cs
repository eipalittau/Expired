using Exp.Data.Feat.Defensive;
using Exp.Util.Enumeration;

namespace Exp.DefaultMod.Feat.Defensive
{
    public sealed class Jostle : DefensiveDataBase, IDefensiveData {
        #region Konstruktor
        private Jostle()
            : base(nameof(Jostle), 100, Api.General.Tier.Singleton.Get(nameof(General.Tier.One)), Api.General.ActionType.Singleton.Get(nameof(General.ActionType.Free))) {
            Name.Set(LanguageEnum.Deutsch, "Schubsen");
            Name.Set(LanguageEnum.English, "Jostle");
            LoreDescription.Set(LanguageEnum.Deutsch, "");
            LoreDescription.Set(LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new Jostle());
        }
        #endregion
    }
}