using Exp.Data.Feat;
using Exp.Data.General;

namespace Exp.DefaultMod.Feat.Wonder {
    internal sealed class Tartaros : FeatDataBase<IWonderData>, IWonderData {
        #region Konstruktor
        internal Tartaros()
            : base(nameof(Tartaros), 1600, TierEnum.Three, null) {
            Name.Set(Util.LanguageEnum.Deutsch, "Tartaros");
            Name.Set(Util.LanguageEnum.English, "Tartaros");
            Description.Set(Util.LanguageEnum.Deutsch, "");
            Description.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}