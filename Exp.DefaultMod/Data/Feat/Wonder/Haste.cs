using Exp.Data.Feat;
using Exp.Data.General;

namespace Exp.DefaultMod.Feat.Wonder {
    internal sealed class Haste : FeatDataBase<IWonderData>, IWonderData {
        #region Konstruktor
        internal Haste()
            : base(nameof(Haste), 500, TierEnum.One, ActionTypeEnum.Standard) {
            Name.Set(Util.LanguageEnum.Deutsch, "Hast");
            Name.Set(Util.LanguageEnum.English, "Haste");
            Description.Set(Util.LanguageEnum.Deutsch, "");
            Description.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}