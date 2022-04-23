using Exp.Data.Feat;
using Exp.Data.General;

namespace Exp.DefaultMod.Feat.Defensive {
    internal sealed class SecondWind : FeatDataBase<IDefensiveData>, IDefensiveData {
        #region Konstruktor
        internal SecondWind()
            : base(nameof(SecondWind), 1000, TierEnum.Two, ActionTypeEnum.Standard) {
            Name.Set(Util.LanguageEnum.Deutsch, "Zweiter Wind");
            Name.Set(Util.LanguageEnum.English, "Second wind");
            Description.Set(Util.LanguageEnum.Deutsch, "");
            Description.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}