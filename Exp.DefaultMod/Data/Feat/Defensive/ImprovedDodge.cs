using Exp.Data.Feat.Defensive;

namespace Exp.DefaultMod.Feat.Defensive {
    public sealed class ImprovedDodge : DefensiveDataBase, IDefensiveData {
        #region Konstruktor
        private ImprovedDodge()
            : base(nameof(ImprovedDodge), 1300, Api.General.Tier.Singleton.Get(nameof(General.Tier.Two)), Api.Feat.Defensive.Singleton.Get(nameof(Dodge))) {
            Name.Set(Util.LanguageEnum.Deutsch, "Verbessertes Ausweichen");
            Name.Set(Util.LanguageEnum.English, "Improved dodge");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new ImprovedDodge());
        }
        #endregion
    }
}