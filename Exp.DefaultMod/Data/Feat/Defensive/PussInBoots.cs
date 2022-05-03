using Exp.Data.Feat;

namespace Exp.DefaultMod.Feat.Defensive {
    internal sealed class PussInBoots : DefensiveDataBase, IDefensiveData {
        #region Konstruktor
        internal PussInBoots()
            : base(nameof(PussInBoots), 1400, Api.General.Tier.Singleton.Get(nameof(General.Tier.Two)), null) {
            Name.Set(Util.LanguageEnum.Deutsch, "Der gestiefelte Kater");
            Name.Set(Util.LanguageEnum.English, "Puss in boots");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}