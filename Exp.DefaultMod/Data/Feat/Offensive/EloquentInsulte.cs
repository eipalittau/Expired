using Exp.Data.Feat;
using Exp.Data.General;

namespace Exp.DefaultMod.Feat.Offensive {
    internal sealed class EloquentInsulte : FeatDataBase<IOffensiveData>, IOffensiveData {
        #region Konstruktor
        internal EloquentInsulte()
            : base(nameof(EloquentInsulte), 300, TierEnum.One, ActionTypeEnum.Standard) {
            Name.Set(Util.LanguageEnum.Deutsch, "Eloquent beleidigen");
            Name.Set(Util.LanguageEnum.English, "Eloquent insulte");
            Description.Set(Util.LanguageEnum.Deutsch, "");
            Description.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}