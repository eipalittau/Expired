using Exp.Data.Feat;
using Exp.Data.General;

namespace Exp.DefaultMod.Feat.Defensive {
    internal sealed class Pindown : FeatDataBase<IDefensiveData>, IDefensiveData {
        #region Konstruktor
        internal Pindown()
            : base(nameof(Pindown), 800, TierEnum.One, null) {
            Name.Set(Util.LanguageEnum.Deutsch, "Anpinnen");
            Name.Set(Util.LanguageEnum.English, "Pindown");
            Description.Set(Util.LanguageEnum.Deutsch, "");
            Description.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}