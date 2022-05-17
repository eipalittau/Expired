using Exp.Data.Feat.Offensive;

namespace Exp.DefaultMod.Feat.Offensive {
    public sealed class QuickShot : OffensiveDataBase, IOffensiveData {
        #region Konstruktor
        private QuickShot()
            : base(nameof(QuickShot), 1300, Api.General.Tier.Singleton.Get(nameof(General.Tier.Two))) {
            Name.Set(Util.LanguageEnum.Deutsch, "Schnellschuss");
            Name.Set(Util.LanguageEnum.English, "quick shot");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new QuickShot());
        }
        #endregion
    }
}