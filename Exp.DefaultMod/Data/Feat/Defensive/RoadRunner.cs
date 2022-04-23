using Exp.Data.Feat;
using Exp.Data.General;

namespace Exp.DefaultMod.Feat.Defensive {
    internal sealed class RoadRunner : FeatDataBase<IDefensiveData>, IDefensiveData {
        #region Konstruktor
        internal RoadRunner()
            : base(nameof(RoadRunner), 1500, TierEnum.Two, null) {
            Name.Set(Util.LanguageEnum.Deutsch, "Road runner");
            Name.Set(Util.LanguageEnum.English, "Straßenläufer");
            Description.Set(Util.LanguageEnum.Deutsch, "");
            Description.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}