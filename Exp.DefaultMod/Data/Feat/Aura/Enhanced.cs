using Exp.Data.Feat;
using Exp.Data.General;

namespace Exp.DefaultMod.Feat.Aura {
    internal sealed class Enhanced : FeatDataBase<IAuraData>, IAuraData {
        #region Konstruktor
        internal Enhanced()
            : base(nameof(Enhanced), 800, TierEnum.One, null) {
            Name.Set(Util.LanguageEnum.Deutsch, "Verstärkte Aura");
            Name.Set(Util.LanguageEnum.English, "Enhanced aura");
            Description.Set(Util.LanguageEnum.Deutsch, "");
            Description.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}