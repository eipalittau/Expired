using Exp.Data.Feat.Offensive;

namespace Exp.DefaultMod.Feat.Offensive {
    public sealed class PreciseShot : OffensiveDataBase, IOffensiveData {
        #region Konstruktor
        private PreciseShot()
            : base(nameof(PreciseShot), 400, Api.General.Tier.Singleton.Get(nameof(General.Tier.One))) {
            Name.Set(Util.LanguageEnum.Deutsch, "Präziser Schuss");
            Name.Set(Util.LanguageEnum.English, "Precise shot");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new PreciseShot());
        }
        #endregion
    }
}