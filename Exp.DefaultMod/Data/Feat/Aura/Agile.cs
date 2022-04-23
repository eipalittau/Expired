using Exp.Data.Feat;
using Exp.Data.General;

namespace Exp.DefaultMod.Feat.Aura {
    internal sealed class Agile : FeatDataBase<IAuraData>, IAuraData {
        #region Konstruktor
        internal Agile()
            : base(nameof(Agile), 1100, TierEnum.One, null) {
            Name.Set(Util.LanguageEnum.Deutsch, "Geschickt");
            Name.Set(Util.LanguageEnum.English, "Agile");
            Description.Set(Util.LanguageEnum.Deutsch, "");
            Description.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}