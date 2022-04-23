using Exp.Data.Feat;
using Exp.Data.General;

namespace Exp.DefaultMod.Feat.Defensive {
    internal sealed class Tough : FeatDataBase<IDefensiveData>, IDefensiveData {
        #region Konstruktor
        internal Tough()
            : base(nameof(Tough), 200, TierEnum.One, null) {
            Name.Set(Util.LanguageEnum.Deutsch, "Zäh");
            Name.Set(Util.LanguageEnum.English, "Tough");
            Description.Set(Util.LanguageEnum.Deutsch, "");
            Description.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}