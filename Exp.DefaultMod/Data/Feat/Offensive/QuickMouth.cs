using Exp.Data.Feat;
using Exp.Data.General;

namespace Exp.DefaultMod.Feat.Offensive {
    internal sealed class QuickMouth : FeatDataBase<IOffensiveData>, IOffensiveData {
        #region Konstruktor
        internal QuickMouth()
            : base(nameof(QuickMouth), 1100, TierEnum.Two, ActionTypeEnum.Move, Api.Feat.Offensive.Singleton.Get("EloquentInsulte")) {
            Name.Set(Util.LanguageEnum.Deutsch, "Schnelles Mundwerk");
            Name.Set(Util.LanguageEnum.English, "Quick mouth");
            Description.Set(Util.LanguageEnum.Deutsch, "");
            Description.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}