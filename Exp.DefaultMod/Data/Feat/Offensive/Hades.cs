using Exp.Data.Feat.Offensive;

namespace Exp.DefaultMod.Feat.Offensive {
    public sealed class Hades : OffensiveDataBase, IOffensiveData {
        #region Konstruktor
        private Hades()
            : base(nameof(Hades), 2000, Api.General.Tier.Singleton.Get(nameof(General.Tier.Three))) {
            Name.Set(Util.LanguageEnum.Deutsch, "Hades");
            Name.Set(Util.LanguageEnum.English, "Hades");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new Hades());
        }
        #endregion
    }
}