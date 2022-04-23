using Exp.Data.Feat;
using Exp.Data.General;

namespace Exp.DefaultMod.Feat.Offensive {
    internal sealed class Anatomy : FeatDataBase<IOffensiveData>, IOffensiveData {
        #region Konstruktor
        internal Anatomy()
            : base(nameof(Anatomy), 1400, TierEnum.Two, null) {
            Name.Set(Util.LanguageEnum.Deutsch, "Anatomie");
            Name.Set(Util.LanguageEnum.English, "Anatomy");
            Description.Set(Util.LanguageEnum.Deutsch, "");
            Description.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}