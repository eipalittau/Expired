using Exp.Data.Feat;
using Exp.Data.General;

namespace Exp.DefaultMod.Feat.Defensive {
    internal sealed class Zeus : FeatDataBase<IDefensiveData>, IDefensiveData {
        #region Konstruktor
        internal Zeus()
            : base(nameof(Zeus), 1800, TierEnum.Three, null) {
            Name.Set(Util.LanguageEnum.Deutsch, "Zeus");
            Name.Set(Util.LanguageEnum.English, "Zeus");
            Description.Set(Util.LanguageEnum.Deutsch, "");
            Description.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}