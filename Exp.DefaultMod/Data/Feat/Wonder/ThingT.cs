using Exp.Data.Feat;

namespace Exp.DefaultMod.Feat.Wonder {
    internal sealed class ThingT : FeatDataBase<IWonderData>, IWonderData {
        #region Konstruktor
        internal ThingT()
            : base(nameof(ThingT), 400, Api.General.Tier.Singleton.Get(nameof(Data.General.Tier.One)), Api.General.ActionType.Singleton.Get(nameof(Data.General.ActionType.Standard))) {
            Name.Set(Util.LanguageEnum.Deutsch, "Eiskaltes Händchen");
            Name.Set(Util.LanguageEnum.English, "ThingT"); //Englische Übersetzung aus "Addams Family"
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}