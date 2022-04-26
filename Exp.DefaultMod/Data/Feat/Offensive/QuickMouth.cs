using Exp.Data.Feat;

namespace Exp.DefaultMod.Feat.Offensive {
    internal sealed class QuickMouth : FeatDataBase<IOffensiveData>, IOffensiveData {
        #region Konstruktor
        internal QuickMouth()
            : base(nameof(QuickMouth), 1100, Api.General.Tier.Singleton.Get(nameof(Data.General.Tier.Two)), Api.General.ActionType.Singleton.Get(nameof(Data.General.ActionType.Move)), Api.Feat.Offensive.Singleton.Get(nameof(EloquentInsulte))) {
            Name.Set(Util.LanguageEnum.Deutsch, "Schnelles Mundwerk");
            Name.Set(Util.LanguageEnum.English, "Quick mouth");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}