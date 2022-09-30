using Exp.Data.Feat.Defensive;
using Exp.Util.Enumeration;

namespace Exp.DefaultMod.Feat.Defensive
{
    public sealed class Teamplayer : DefensiveDataBase, IDefensiveData {
        #region Konstruktor
        private Teamplayer()
            : base(nameof(Teamplayer), 700, Api.General.Tier.Singleton.Get(nameof(General.Tier.One))) {
            Name.Set(LanguageEnum.Deutsch, "Teamplayer");
            Name.Set(LanguageEnum.English, "Teamplayer");
            LoreDescription.Set(LanguageEnum.Deutsch, "");
            LoreDescription.Set(LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new Teamplayer());
        }
        #endregion
    }
}