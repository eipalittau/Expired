using Exp.Data.Feat;

namespace Exp.DefaultMod.Feat.Offensive {
    internal sealed class SweepingBlow : FeatDataBase<IOffensiveData>, IOffensiveData {
        #region Konstruktor
        internal SweepingBlow()
            : base(nameof(SweepingBlow), 500, Api.General.Tier.Singleton.Get(nameof(Data.General.Tier.One)), Api.General.ActionType.Singleton.Get(nameof(Data.General.ActionType.Standard))) {
            Name.Set(Util.LanguageEnum.Deutsch, "Rundumschlag");
            Name.Set(Util.LanguageEnum.English, "Sweeping blow");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}