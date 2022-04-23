using Exp.Data.Feat;
using Exp.Data.General;

namespace Exp.DefaultMod.Feat.Aura {
    internal sealed class Flatulence : FeatDataBase<IAuraData>, IAuraData {
        #region Konstruktor
        internal Flatulence()
            : base(nameof(Flatulence), 900, TierEnum.One, null) {
            Name.Set(Util.LanguageEnum.Deutsch, "Blähungen");
            Name.Set(Util.LanguageEnum.English, "Flatulence");
            Description.Set(Util.LanguageEnum.Deutsch, "");
            Description.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}