using Exp.Data.Feat;
using Exp.Data.General;

namespace Exp.DefaultMod.Feat.Aura {
    internal sealed class Will : FeatDataBase<IAuraData>, IAuraData {
        #region Konstruktor
        internal Will()
            : base(nameof(Will), 500, TierEnum.One, null) {
            Name.Set(Util.LanguageEnum.Deutsch, "Aura des Willens");
            Name.Set(Util.LanguageEnum.English, "Aura of will");
            Description.Set(Util.LanguageEnum.Deutsch, "");
            Description.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}