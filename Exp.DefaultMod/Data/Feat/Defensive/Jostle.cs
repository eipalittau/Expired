using Exp.Data.Feat;

namespace Exp.DefaultMod.Feat.Defensive {
    internal sealed class Jostle : FeatDataBase<IDefensiveData>, IDefensiveData {
        #region Konstruktor
        internal Jostle()
            : base(nameof(Jostle), 100, Api.General.Tier.Singleton.Get(nameof(Data.General.Tier.One)), Api.General.ActionType.Singleton.Get(nameof(Data.General.ActionType.Free))) {
            Name.Set(Util.LanguageEnum.Deutsch, "Schubsen");
            Name.Set(Util.LanguageEnum.English, "Jostle");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}