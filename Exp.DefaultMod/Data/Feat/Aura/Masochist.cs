using Exp.Data.Feat;
using Exp.Data.General;

namespace Exp.DefaultMod.Feat.Aura {
    internal sealed class Masochist : FeatDataBase<IAuraData>, IAuraData {
        #region Konstruktor
        internal Masochist()
            : base(nameof(Masochist), 1500, TierEnum.One, null) {
            Name.Set(Util.LanguageEnum.Deutsch, "Masochist");
            Name.Set(Util.LanguageEnum.English, "Masochist");
            Description.Set(Util.LanguageEnum.Deutsch, "");
            Description.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}