using Exp.Data.Feat;
using Exp.Data.General;

namespace Exp.DefaultMod.Feat.Defensive {
    internal sealed class DangerInstinct : FeatDataBase<IDefensiveData>, IDefensiveData {
        #region Konstruktor
        internal DangerInstinct()
            : base(nameof(DangerInstinct), 400, TierEnum.One, null) {
            Name.Set(Util.LanguageEnum.Deutsch, "Gefahreninstinkt");
            Name.Set(Util.LanguageEnum.English, "Danger instinct");
            Description.Set(Util.LanguageEnum.Deutsch, "");
            Description.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}