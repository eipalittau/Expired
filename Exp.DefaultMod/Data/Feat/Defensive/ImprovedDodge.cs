using Exp.Data.Feat.Defensive;
using Exp.Util.Enumeration;

namespace Exp.DefaultMod.Feat.Defensive
{
    public sealed class ImprovedDodge : DefensiveDataBase, IDefensiveData {
        #region Konstruktor
        private ImprovedDodge()
            : base(nameof(ImprovedDodge), 1300, Api.General.Tier.Singleton.Get(nameof(General.Tier.Two)), Api.Feat.Defensive.Singleton.Get(nameof(Dodge))) {
            Name.Set(LanguageEnum.Deutsch, "Verbessertes Ausweichen");
            Name.Set(LanguageEnum.English, "Improved dodge");
            LoreDescription.Set(LanguageEnum.Deutsch, "");
            LoreDescription.Set(LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new ImprovedDodge());
        }
        #endregion
    }
}