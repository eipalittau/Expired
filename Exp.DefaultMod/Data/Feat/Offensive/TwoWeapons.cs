using Exp.Data.Feat.Offensive;
using Exp.Util.Enumeration;

namespace Exp.DefaultMod.Feat.Offensive
{
    public sealed class TwoWeapons : OffensiveDataBase, IOffensiveData {
        #region Konstruktor
        private TwoWeapons()
            : base(nameof(TwoWeapons), 800, Api.General.Tier.Singleton.Get(nameof(General.Tier.One))) {
            Name.Set(LanguageEnum.Deutsch, "Kampf mit zwei Waffen");
            Name.Set(LanguageEnum.English, "Fight with two weapons");
            LoreDescription.Set(LanguageEnum.Deutsch, "");
            LoreDescription.Set(LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new TwoWeapons());
        }
        #endregion
    }
}