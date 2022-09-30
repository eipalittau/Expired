using Exp.Data.Feat.Defensive;
using Exp.Util.Enumeration;

namespace Exp.DefaultMod.Feat.Defensive
{
    public sealed class StoneSkin : DefensiveDataBase, IDefensiveData {
        #region Konstruktor
        private StoneSkin()
            : base(nameof(StoneSkin), 1200, Api.General.Tier.Singleton.Get(nameof(General.Tier.Two))) {
            Name.Set(LanguageEnum.Deutsch, "Steinhaut");
            Name.Set(LanguageEnum.English, "Stone skin");
            LoreDescription.Set(LanguageEnum.Deutsch, "");
            LoreDescription.Set(LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new StoneSkin());
        }
        #endregion
    }
}