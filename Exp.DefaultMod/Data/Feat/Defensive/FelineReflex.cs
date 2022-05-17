using Exp.Data.Feat.Defensive;

namespace Exp.DefaultMod.Feat.Defensive {
    public sealed class FelineReflex : DefensiveDataBase, IDefensiveData {
        #region Konstruktor
        private FelineReflex()
            : base(nameof(FelineReflex), 300, Api.General.Tier.Singleton.Get(nameof(General.Tier.One))) {
            Name.Set(Util.LanguageEnum.Deutsch, "Katzenreflex");
            Name.Set(Util.LanguageEnum.English, "Feline reflex");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new FelineReflex());
        }
        #endregion
    }
}