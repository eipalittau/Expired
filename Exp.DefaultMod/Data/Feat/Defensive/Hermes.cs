using Exp.Data.Feat;
using Exp.Data.General;

namespace Exp.DefaultMod.Feat.Defensive {
    internal sealed class Hermes : FeatDataBase<IDefensiveData>, IDefensiveData {
        #region Konstruktor
        internal Hermes()
            : base(nameof(Hermes), 1600, TierEnum.Three, null) {
            Name.Set(Util.LanguageEnum.Deutsch, "Hermes");
            Name.Set(Util.LanguageEnum.English, "Hermes");
            Description.Set(Util.LanguageEnum.Deutsch, "");
            Description.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}