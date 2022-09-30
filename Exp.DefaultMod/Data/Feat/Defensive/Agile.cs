using Exp.Data.Feat.Defensive;
using Exp.Util.Enumeration;

namespace Exp.DefaultMod.Feat.Defensive
{
    public sealed class Agile : DefensiveDataBase, IDefensiveData {
        #region Konstruktor
        private Agile()
            : base(nameof(Agile), 600, Api.General.Tier.Singleton.Get(nameof(General.Tier.One))) {
            Name.Set(LanguageEnum.Deutsch, "Agil");
            Name.Set(LanguageEnum.English, "Agile");
            LoreDescription.Set(LanguageEnum.Deutsch, "");
            LoreDescription.Set(LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new Agile());
        }
        #endregion
    }
}