using Exp.Data.Feat.Defensive;
using Exp.Util.Enumeration;

namespace Exp.DefaultMod.Feat.Defensive
{
    public sealed class Shadowy : DefensiveDataBase, IDefensiveData {
        #region Konstruktor
        private Shadowy()
            : base(nameof(Shadowy), 900, Api.General.Tier.Singleton.Get(nameof(General.Tier.Two))) {
            Name.Set(LanguageEnum.Deutsch, "Schattenhaft");
            Name.Set(LanguageEnum.English, "Shadowy");
            LoreDescription.Set(LanguageEnum.Deutsch, "");
            LoreDescription.Set(LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new Shadowy());
        }
        #endregion
    }
}