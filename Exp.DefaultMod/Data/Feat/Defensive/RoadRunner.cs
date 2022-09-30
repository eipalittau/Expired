using Exp.Data.Feat.Defensive;
using Exp.Util.Enumeration;

namespace Exp.DefaultMod.Feat.Defensive
{
    public sealed class RoadRunner : DefensiveDataBase, IDefensiveData {
        #region Konstruktor
        private RoadRunner()
            : base(nameof(RoadRunner), 1500, Api.General.Tier.Singleton.Get(nameof(General.Tier.Two))) {
            Name.Set(LanguageEnum.Deutsch, "Road runner");
            Name.Set(LanguageEnum.English, "Straßenläufer");
            LoreDescription.Set(LanguageEnum.Deutsch, "");
            LoreDescription.Set(LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new RoadRunner());
        }
        #endregion
    }
}