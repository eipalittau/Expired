using Exp.Data.Feat;
using Exp.Data.General;

namespace Exp.DefaultMod.Feat.Wonder {
    internal sealed class Styx : FeatDataBase<IWonderData>, IWonderData {
        #region Konstruktor
        internal Styx()
            : base(nameof(Styx), 1800, TierEnum.Three, ActionTypeEnum.Standard) {
            Name.Set(Util.LanguageEnum.Deutsch, "Styx");
            Name.Set(Util.LanguageEnum.English, "Styx");
            Description.Set(Util.LanguageEnum.Deutsch, "");
            Description.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}