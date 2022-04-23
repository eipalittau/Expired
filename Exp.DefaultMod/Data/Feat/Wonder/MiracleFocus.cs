using Exp.Data.Feat;
using Exp.Data.General;

namespace Exp.DefaultMod.Feat.Wonder {
    internal sealed class MiracleFocus : FeatDataBase<IWonderData>, IWonderData {
        #region Konstruktor
        internal MiracleFocus()
            : base(nameof(MiracleFocus), 700, TierEnum.One, null) {
            Name.Set(Util.LanguageEnum.Deutsch, "Wunderfokus");
            Name.Set(Util.LanguageEnum.English, "Miracle focus");
            Description.Set(Util.LanguageEnum.Deutsch, "");
            Description.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}