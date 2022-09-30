using Exp.Data.Feat.Defensive;
using Exp.Util.Enumeration;

namespace Exp.DefaultMod.Feat.Defensive
{
    public sealed class Tough : DefensiveDataBase, IDefensiveData {
        #region Konstruktor
        private Tough()
            : base(nameof(Tough), 200, Api.General.Tier.Singleton.Get(nameof(General.Tier.One))) {
            Name.Set(LanguageEnum.Deutsch, "Zäh");
            Name.Set(LanguageEnum.English, "Tough");
            LoreDescription.Set(LanguageEnum.Deutsch, "");
            LoreDescription.Set(LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new Tough());
        }
        #endregion
    }
}