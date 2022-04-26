using Exp.Data.Feat;

namespace Exp.DefaultMod.Feat.Offensive {
    internal sealed class Stonethrower : FeatDataBase<IOffensiveData>, IOffensiveData {
        #region Konstruktor
        internal Stonethrower()
            : base(nameof(Stonethrower), 200, Api.General.Tier.Singleton.Get(nameof(Data.General.Tier.One)), Api.General.ActionType.Singleton.Get(nameof(Data.General.ActionType.Standard))) {
            Name.Set(Util.LanguageEnum.Deutsch, "Steinwerfer");
            Name.Set(Util.LanguageEnum.English, "Stone thrower");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}