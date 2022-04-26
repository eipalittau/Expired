using Exp.Data.Feat;

namespace Exp.DefaultMod.Feat.Wonder {
    internal sealed class Haste : FeatDataBase<IWonderData>, IWonderData {
        #region Konstruktor
        internal Haste()
            : base(nameof(Haste), 500, Api.General.Tier.Singleton.Get(nameof(Data.General.Tier.One)), Api.General.ActionType.Singleton.Get(nameof(Data.General.ActionType.Standard))) {
            Name.Set(Util.LanguageEnum.Deutsch, "Hast");
            Name.Set(Util.LanguageEnum.English, "Haste");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}