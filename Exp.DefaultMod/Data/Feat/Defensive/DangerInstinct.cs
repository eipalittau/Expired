using Exp.Data.Feat.Defensive;
using Exp.Util.Enumeration;

namespace Exp.DefaultMod.Feat.Defensive
{
    public sealed class DangerInstinct : DefensiveDataBase, IDefensiveData {
        #region Konstruktor
        private DangerInstinct()
            : base(nameof(DangerInstinct), 400, Api.General.Tier.Singleton.Get(nameof(General.Tier.One))) {
            Name.Set(LanguageEnum.Deutsch, "Gefahreninstinkt");
            Name.Set(LanguageEnum.English, "Danger instinct");
            LoreDescription.Set(LanguageEnum.Deutsch, "");
            LoreDescription.Set(LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new DangerInstinct());
        }
        #endregion
    }
}