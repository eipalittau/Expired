using Exp.Data.Feat;
using Exp.Data.General;

namespace Exp.DefaultMod.Feat.Defensive {
    internal sealed class Agile : FeatDataBase<IDefensiveData>, IDefensiveData {
        #region Konstruktor
        internal Agile()
            : base(nameof(Agile), 600, TierEnum.One, null) {
            Name.Set(Util.LanguageEnum.Deutsch, "Agil");
            Name.Set(Util.LanguageEnum.English, "Agile");
            Description.Set(Util.LanguageEnum.Deutsch, "");
            Description.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}