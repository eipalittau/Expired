using Exp.Data.Feat;

namespace Exp.DefaultMod.Feat.Wonder {
    internal sealed class Brains : FeatDataBase<IWonderData>, IWonderData {
        #region Konstruktor
        internal Brains()
            : base(nameof(Brains), 1300, Api.General.Tier.Singleton.Get(nameof(Data.General.Tier.Two)), Api.General.ActionType.Singleton.Get(nameof(Data.General.ActionType.Full))) {
            Name.Set(Util.LanguageEnum.Deutsch, "BRAINZZZZ!");
            Name.Set(Util.LanguageEnum.English, "BRAINZZZZ!");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}