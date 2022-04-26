using Exp.Data.Feat;

namespace Exp.DefaultMod.Feat.Wonder {
    internal sealed class Lubricate : FeatDataBase<IWonderData>, IWonderData {
        #region Konstruktor
        internal Lubricate()
            : base(nameof(Lubricate), 600, Api.General.Tier.Singleton.Get(nameof(Data.General.Tier.One)), Api.General.ActionType.Singleton.Get(nameof(Data.General.ActionType.Standard))) {
            Name.Set(Util.LanguageEnum.Deutsch, "Schmieren");
            Name.Set(Util.LanguageEnum.English, "Lubricate");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}