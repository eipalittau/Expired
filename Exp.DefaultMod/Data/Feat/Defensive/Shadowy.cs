using Exp.Data.Feat.Defensive;

namespace Exp.DefaultMod.Feat.Defensive {
    public sealed class Shadowy : DefensiveDataBase, IDefensiveData {
        #region Konstruktor
        private Shadowy()
            : base(nameof(Shadowy), 900, Api.General.Tier.Singleton.Get(nameof(General.Tier.Two))) {
            Name.Set(Util.LanguageEnum.Deutsch, "Schattenhaft");
            Name.Set(Util.LanguageEnum.English, "Shadowy");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new Shadowy());
        }
        #endregion
    }
}