using Exp.Data.Feat.Defensive;

namespace Exp.DefaultMod.Feat.Defensive {
    public sealed class Agile : DefensiveDataBase, IDefensiveData {
        #region Konstruktor
        private Agile()
            : base(nameof(Agile), 600, Api.General.Tier.Singleton.Get(nameof(General.Tier.One))) {
            Name.Set(Util.LanguageEnum.Deutsch, "Agil");
            Name.Set(Util.LanguageEnum.English, "Agile");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new Agile());
        }
        #endregion
    }
}