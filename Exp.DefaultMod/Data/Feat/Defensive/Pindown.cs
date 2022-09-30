using Exp.Data.Feat.Defensive;
using Exp.Util.Enumeration;

namespace Exp.DefaultMod.Feat.Defensive
{
    public sealed class Pindown : DefensiveDataBase, IDefensiveData {
        #region Konstruktor
        private Pindown()
            : base(nameof(Pindown), 800, Api.General.Tier.Singleton.Get(nameof(General.Tier.One))) {
            Name.Set(LanguageEnum.Deutsch, "Anpinnen");
            Name.Set(LanguageEnum.English, "Pindown");
            LoreDescription.Set(LanguageEnum.Deutsch, "");
            LoreDescription.Set(LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new Pindown());
        }
        #endregion
    }
}