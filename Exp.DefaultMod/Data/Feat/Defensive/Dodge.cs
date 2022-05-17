using Exp.Data.Feat.Defensive;

namespace Exp.DefaultMod.Feat.Defensive {
    public sealed class Dodge : DefensiveDataBase, IDefensiveData {
        #region Konstruktor
        private Dodge()
            : base(nameof(Dodge), 500, Api.General.Tier.Singleton.Get(nameof(General.Tier.One))) {
            Name.Set(Util.LanguageEnum.Deutsch, "Ausweichen");
            Name.Set(Util.LanguageEnum.English, "Dodge");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new Dodge());
        }
        #endregion
    }
}