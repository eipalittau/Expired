using Exp.Data.Feat.Defensive;

namespace Exp.DefaultMod.Feat.Defensive {
    public sealed class StoneSkin : DefensiveDataBase, IDefensiveData {
        #region Konstruktor
        private StoneSkin()
            : base(nameof(StoneSkin), 1200, Api.General.Tier.Singleton.Get(nameof(General.Tier.Two))) {
            Name.Set(Util.LanguageEnum.Deutsch, "Steinhaut");
            Name.Set(Util.LanguageEnum.English, "Stone skin");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new StoneSkin());
        }
        #endregion
    }
}