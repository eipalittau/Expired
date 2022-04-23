using Exp.Data.Feat;
using Exp.Data.General;

namespace Exp.DefaultMod.Feat.Aura {
    internal sealed class Focus : FeatDataBase<IAuraData>, IAuraData {
        #region Konstruktor
        internal Focus()
            : base(nameof(Focus), 700, TierEnum.One, null) {
            Name.Set(Util.LanguageEnum.Deutsch, "Fokus");
            Name.Set(Util.LanguageEnum.English, "Focus");
            Description.Set(Util.LanguageEnum.Deutsch, "");
            Description.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}