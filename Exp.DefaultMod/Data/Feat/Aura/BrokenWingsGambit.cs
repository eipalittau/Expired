using Exp.Data.Feat;
using Exp.Data.General;

namespace Exp.DefaultMod.Feat.Aura {
    internal sealed class BrokenWingsGambit : FeatDataBase<IAuraData>, IAuraData {
        #region Konstruktor
        internal BrokenWingsGambit()
            : base(nameof(BrokenWingsGambit), 1000, TierEnum.One, ActionTypeEnum.Free) {
            Name.Set(Util.LanguageEnum.Deutsch, "Gambit der gebrochenen Flügel");
            Name.Set(Util.LanguageEnum.English, "Broken Wings Gambit");
            Description.Set(Util.LanguageEnum.Deutsch, "");
            Description.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}