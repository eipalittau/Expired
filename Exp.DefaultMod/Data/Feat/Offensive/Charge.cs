using Exp.Data.Feat;

namespace Exp.DefaultMod.Feat.Offensive {
    internal sealed class Charge : FeatDataBase<IOffensiveData>, IOffensiveData {
        #region Konstruktor
        internal Charge()
            : base(nameof(Charge), 600, Api.General.Tier.Singleton.Get(nameof(Data.General.Tier.One)), Api.General.ActionType.Singleton.Get(nameof(Data.General.ActionType.Full))) {
            Name.Set(Util.LanguageEnum.Deutsch, "CHARGE!");
            Name.Set(Util.LanguageEnum.English, "CHARGE!");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}