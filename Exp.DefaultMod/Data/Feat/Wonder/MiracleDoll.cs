using Exp.Data.Feat;
using Exp.Data.General;

namespace Exp.DefaultMod.Feat.Wonder {
    internal sealed class MiracleDoll : FeatDataBase<IWonderData>, IWonderData {
        #region Konstruktor
        internal MiracleDoll()
            : base(nameof(MiracleDoll), 300, TierEnum.One, ActionTypeEnum.Standard) {
            Name.Set(Util.LanguageEnum.Deutsch, "Wunderpuppe");
            Name.Set(Util.LanguageEnum.English, "Miracle doll");
            Description.Set(Util.LanguageEnum.Deutsch, "");
            Description.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}