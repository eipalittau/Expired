using Exp.Data.Feat;
using Exp.Data.General;

namespace Exp.DefaultMod.Feat.Wonder {
    internal sealed class Lubricate : FeatDataBase<IWonderData>, IWonderData {
        #region Konstruktor
        internal Lubricate()
            : base(nameof(Lubricate), 600, TierEnum.One, ActionTypeEnum.Standard) {
            Name.Set(Util.LanguageEnum.Deutsch, "Schmieren");
            Name.Set(Util.LanguageEnum.English, "Lubricate");
            Description.Set(Util.LanguageEnum.Deutsch, "");
            Description.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}