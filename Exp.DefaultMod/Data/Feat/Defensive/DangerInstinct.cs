using Exp.Data.Feat.Defensive;

namespace Exp.DefaultMod.Feat.Defensive {
    public sealed class DangerInstinct : DefensiveDataBase, IDefensiveData {
        #region Konstruktor
        private DangerInstinct()
            : base(nameof(DangerInstinct), 400, Api.General.Tier.Singleton.Get(nameof(General.Tier.One))) {
            Name.Set(Util.LanguageEnum.Deutsch, "Gefahreninstinkt");
            Name.Set(Util.LanguageEnum.English, "Danger instinct");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new DangerInstinct());
        }
        #endregion
    }
}