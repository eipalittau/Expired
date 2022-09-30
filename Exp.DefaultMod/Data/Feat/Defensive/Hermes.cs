using Exp.Data.Feat.Defensive;
using Exp.Util.Enumeration;

namespace Exp.DefaultMod.Feat.Defensive
{
    public sealed class Hermes : DefensiveDataBase, IDefensiveData {
        #region Konstruktor
        private Hermes()
            : base(nameof(Hermes), 1600, Api.General.Tier.Singleton.Get(nameof(General.Tier.Three))) {
            Name.Set(LanguageEnum.Deutsch, "Hermes");
            Name.Set(LanguageEnum.English, "Hermes");
            LoreDescription.Set(LanguageEnum.Deutsch, "");
            LoreDescription.Set(LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new Hermes());
        }
        #endregion
    }
}