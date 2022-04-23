using Exp.Data.Feat;
using Exp.Data.General;

namespace Exp.DefaultMod.Feat.Defensive {
    internal sealed class Shadowy : FeatDataBase<IDefensiveData>, IDefensiveData {
        #region Konstruktor
        internal Shadowy()
            : base(nameof(Shadowy), 900, TierEnum.Two, null) {
            Name.Set(Util.LanguageEnum.Deutsch, "Schattenhaft");
            Name.Set(Util.LanguageEnum.English, "Shadowy");
            Description.Set(Util.LanguageEnum.Deutsch, "");
            Description.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}