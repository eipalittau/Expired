using Exp.Data.Feat.Defensive;
using Exp.Util.Enumeration;

namespace Exp.DefaultMod.Feat.Defensive
{
    public sealed class Dodge : DefensiveDataBase, IDefensiveData {
        #region Konstruktor
        private Dodge()
            : base(nameof(Dodge), 500, Api.General.Tier.Singleton.Get(nameof(General.Tier.One))) {
            Name.Set(LanguageEnum.Deutsch, "Ausweichen");
            Name.Set(LanguageEnum.English, "Dodge");
            LoreDescription.Set(LanguageEnum.Deutsch, "");
            LoreDescription.Set(LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new Dodge());
        }
        #endregion
    }
}