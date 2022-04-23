using Exp.Data.Feat;
using Exp.Data.General;

namespace Exp.DefaultMod.Feat.Aura {
    internal sealed class Sadist : FeatDataBase<IAuraData>, IAuraData {
        #region Konstruktor
        internal Sadist()
            : base(nameof(Sadist), 1400, TierEnum.One, null) {
            Name.Set(Util.LanguageEnum.Deutsch, "Sadist");
            Name.Set(Util.LanguageEnum.English, "Sadist");
            Description.Set(Util.LanguageEnum.Deutsch, "");
            Description.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}