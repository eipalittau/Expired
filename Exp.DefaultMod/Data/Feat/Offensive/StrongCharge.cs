using Exp.Data.Feat;

namespace Exp.DefaultMod.Feat.Offensive {
    internal sealed class StrongCharge : FeatDataBase<IOffensiveData>, IOffensiveData {
        #region Konstruktor
        internal StrongCharge()
            : base(nameof(StrongCharge), 900, Api.General.Tier.Singleton.Get(nameof(Data.General.Tier.One)), Api.General.ActionType.Singleton.Get(nameof(Data.General.ActionType.Full))) {
            Name.Set(Util.LanguageEnum.Deutsch, "CHAAAARGE!!!");
            Name.Set(Util.LanguageEnum.English, "CHAAAARGE!!!");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}