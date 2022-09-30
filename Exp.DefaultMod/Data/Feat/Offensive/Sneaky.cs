using Exp.Data.Feat.Offensive;
using Exp.Util.Enumeration;

namespace Exp.DefaultMod.Feat.Offensive
{
    public sealed class Sneaky : OffensiveDataBase, IOffensiveData {
        #region Konstruktor
        private Sneaky()
            : base(nameof(Sneaky), 1200, Api.General.Tier.Singleton.Get(nameof(General.Tier.Two)), Api.General.ActionType.Singleton.Get(nameof(General.ActionType.Standard))) {
            Name.Set(LanguageEnum.Deutsch, "Hinterhältig");
            Name.Set(LanguageEnum.English, "Sneaky");
            LoreDescription.Set(LanguageEnum.Deutsch, "");
            LoreDescription.Set(LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new Sneaky());
        }
        #endregion
    }
}