using Exp.Data.Feat.Defensive;
using Exp.Util.Enumeration;

namespace Exp.DefaultMod.Feat.Defensive
{
    public sealed class Zeus : DefensiveDataBase, IDefensiveData {
        #region Konstruktor
        private Zeus()
            : base(nameof(Zeus), 1800, Api.General.Tier.Singleton.Get(nameof(General.Tier.Three))) {
            Name.Set(LanguageEnum.Deutsch, "Zeus");
            Name.Set(LanguageEnum.English, "Zeus");
            LoreDescription.Set(LanguageEnum.Deutsch, "");
            LoreDescription.Set(LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new Zeus());
        }
        #endregion
    }
}