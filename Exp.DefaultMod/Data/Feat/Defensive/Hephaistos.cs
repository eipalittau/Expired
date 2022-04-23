using Exp.Data.Feat;
using Exp.Data.General;

namespace Exp.DefaultMod.Feat.Defensive {
    internal sealed class Hephaistos : FeatDataBase<IDefensiveData>, IDefensiveData {
        #region Konstruktor
        internal Hephaistos()
            : base(nameof(Hephaistos), 1700, TierEnum.Three, null) {
            Name.Set(Util.LanguageEnum.Deutsch, "Hephaistos");
            Name.Set(Util.LanguageEnum.English, "Hephaistos");
            Description.Set(Util.LanguageEnum.Deutsch, "");
            Description.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}