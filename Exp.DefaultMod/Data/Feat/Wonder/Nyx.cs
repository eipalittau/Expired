using Exp.Data.Feat;
using Exp.Data.General;

namespace Exp.DefaultMod.Feat.Wonder {
    internal sealed class Nyx : FeatDataBase<IWonderData>, IWonderData {
        #region Konstruktor
        internal Nyx()
            : base(nameof(Nyx), 1700, TierEnum.Three, null) {
            Name.Set(Util.LanguageEnum.Deutsch, "Nyx");
            Name.Set(Util.LanguageEnum.English, "Nyx");
            Description.Set(Util.LanguageEnum.Deutsch, "");
            Description.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}