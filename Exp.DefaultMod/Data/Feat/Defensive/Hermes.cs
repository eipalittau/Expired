using Exp.Data.Feat.Defensive;

namespace Exp.DefaultMod.Feat.Defensive {
    public sealed class Hermes : DefensiveDataBase, IDefensiveData {
        #region Konstruktor
        private Hermes()
            : base(nameof(Hermes), 1600, Api.General.Tier.Singleton.Get(nameof(General.Tier.Three))) {
            Name.Set(Util.LanguageEnum.Deutsch, "Hermes");
            Name.Set(Util.LanguageEnum.English, "Hermes");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new Hermes());
        }
        #endregion
    }
}