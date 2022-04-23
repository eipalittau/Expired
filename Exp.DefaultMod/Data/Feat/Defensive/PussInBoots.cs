using Exp.Data.Feat;
using Exp.Data.General;

namespace Exp.DefaultMod.Feat.Defensive {
    internal sealed class PussInBoots : FeatDataBase<IDefensiveData>, IDefensiveData {
        #region Konstruktor
        internal PussInBoots()
            : base(nameof(PussInBoots), 1400, TierEnum.Two, null) {
            Name.Set(Util.LanguageEnum.Deutsch, "Der gestiefelte Kater");
            Name.Set(Util.LanguageEnum.English, "Puss in boots");
            Description.Set(Util.LanguageEnum.Deutsch, "");
            Description.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}