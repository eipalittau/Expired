using Exp.Data.Feat.Defensive;
using Exp.Util.Enumeration;

namespace Exp.DefaultMod.Feat.Defensive
{
    public sealed class Hephaistos : DefensiveDataBase, IDefensiveData {
        #region Konstruktor
        private Hephaistos()
            : base(nameof(Hephaistos), 1700, Api.General.Tier.Singleton.Get(nameof(General.Tier.Three))) {
            Name.Set(LanguageEnum.Deutsch, "Hephaistos");
            Name.Set(LanguageEnum.English, "Hephaistos");
            LoreDescription.Set(LanguageEnum.Deutsch, "");
            LoreDescription.Set(LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new Hephaistos());
        }
        #endregion
    }
}