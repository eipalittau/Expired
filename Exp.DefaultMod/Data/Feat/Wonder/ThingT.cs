using Exp.Data.Feat;
using Exp.Data.General;

namespace Exp.DefaultMod.Feat.Wonder {
    internal sealed class ThingT : FeatDataBase<IWonderData>, IWonderData {
        #region Konstruktor
        internal ThingT()
            : base(nameof(ThingT), 400, TierEnum.One, ActionTypeEnum.Standard) {
            Name.Set(Util.LanguageEnum.Deutsch, "Eiskaltes Händchen");
            Name.Set(Util.LanguageEnum.English, "ThingT"); //Englische Übersetzung aus "Addams Family"
            Description.Set(Util.LanguageEnum.Deutsch, "");
            Description.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}