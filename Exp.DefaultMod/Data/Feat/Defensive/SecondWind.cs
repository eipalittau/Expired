using Exp.Data.Feat;

namespace Exp.DefaultMod.Feat.Defensive {
    internal sealed class SecondWind : FeatDataBase<IDefensiveData>, IDefensiveData {
        #region Konstruktor
        internal SecondWind()
            : base(nameof(SecondWind), 1000, Api.General.Tier.Singleton.Get(nameof(Data.General.Tier.Two)), Api.General.ActionType.Singleton.Get(nameof(Data.General.ActionType.Standard))) {
            Name.Set(Util.LanguageEnum.Deutsch, "Zweiter Wind");
            Name.Set(Util.LanguageEnum.English, "Second wind");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}