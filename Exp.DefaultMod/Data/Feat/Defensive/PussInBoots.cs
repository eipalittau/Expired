using Exp.Data.Feat.Defensive;
using Exp.Util.Enumeration;

namespace Exp.DefaultMod.Feat.Defensive
{
    public sealed class PussInBoots : DefensiveDataBase, IDefensiveData {
        #region Konstruktor
        private PussInBoots()
            : base(nameof(PussInBoots), 1400, Api.General.Tier.Singleton.Get(nameof(General.Tier.Two))) {
            Name.Set(LanguageEnum.Deutsch, "Der gestiefelte Kater");
            Name.Set(LanguageEnum.English, "Puss in boots");
            LoreDescription.Set(LanguageEnum.Deutsch, "");
            LoreDescription.Set(LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new PussInBoots());
        }
        #endregion
    }
}