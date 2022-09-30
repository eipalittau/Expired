using Exp.Data.Feat.Defensive;
using Exp.Util.Enumeration;

namespace Exp.DefaultMod.Feat.Defensive
{
    public sealed class FelineReflex : DefensiveDataBase, IDefensiveData {
        #region Konstruktor
        private FelineReflex()
            : base(nameof(FelineReflex), 300, Api.General.Tier.Singleton.Get(nameof(General.Tier.One))) {
            Name.Set(LanguageEnum.Deutsch, "Katzenreflex");
            Name.Set(LanguageEnum.English, "Feline reflex");
            LoreDescription.Set(LanguageEnum.Deutsch, "");
            LoreDescription.Set(LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new FelineReflex());
        }
        #endregion
    }
}