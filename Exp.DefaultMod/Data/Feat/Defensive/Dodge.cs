using Exp.Data.Feat;
using Exp.Data.General;

namespace Exp.DefaultMod.Feat.Defensive {
    internal sealed class Dodge : FeatDataBase<IDefensiveData>, IDefensiveData {
        #region Konstruktor
        internal Dodge()
            : base(nameof(Dodge), 500, TierEnum.One, null) {
            Name.Set(Util.LanguageEnum.Deutsch, "Ausweichen");
            Name.Set(Util.LanguageEnum.English, "Dodge");
            Description.Set(Util.LanguageEnum.Deutsch, "");
            Description.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}