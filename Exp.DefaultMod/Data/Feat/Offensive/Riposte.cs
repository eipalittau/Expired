using Exp.Data.Feat;
using Exp.Data.General;

namespace Exp.DefaultMod.Feat.Offensive {
    internal sealed class Riposte : FeatDataBase<IOffensiveData>, IOffensiveData {
        #region Konstruktor
        internal Riposte()
            : base(nameof(Riposte), 1600, TierEnum.Two, null) {
            Name.Set(Util.LanguageEnum.Deutsch, "Antworten");
            Name.Set(Util.LanguageEnum.English, "Riposte");
            Description.Set(Util.LanguageEnum.Deutsch, "");
            Description.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}