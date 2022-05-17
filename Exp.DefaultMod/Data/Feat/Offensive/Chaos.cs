using Exp.Data.Feat.Offensive;

namespace Exp.DefaultMod.Feat.Offensive {
    public sealed class Chaos : OffensiveDataBase, IOffensiveData {
        #region Konstruktor
        private Chaos()
            : base(nameof(Chaos), 1900, Api.General.Tier.Singleton.Get(nameof(General.Tier.Three))) {
            Name.Set(Util.LanguageEnum.Deutsch, "Chaos");
            Name.Set(Util.LanguageEnum.English, "Chaos");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new Chaos());
        }
        #endregion
    }
}