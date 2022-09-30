using Exp.Data.Feat.Defensive;
using Exp.Util.Enumeration;

namespace Exp.DefaultMod.Feat.Defensive
{
    public sealed class Teamwork : DefensiveDataBase, IDefensiveData {
        #region Konstruktor
        private Teamwork()
            : base(nameof(Teamwork), 1100, Api.General.Tier.Singleton.Get(nameof(General.Tier.Two)), Api.Feat.Defensive.Singleton.Get(nameof(Teamplayer))) {
            Name.Set(LanguageEnum.Deutsch, "Teamwork");
            Name.Set(LanguageEnum.English, "Teamwork");
            LoreDescription.Set(LanguageEnum.Deutsch, "");
            LoreDescription.Set(LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new Teamwork());
        }
        #endregion
    }
}