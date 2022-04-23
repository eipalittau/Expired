using Exp.Data.Feat;
using Exp.Data.General;

namespace Exp.DefaultMod.Feat.Wonder {
    internal sealed class Brains : FeatDataBase<IWonderData>, IWonderData {
        #region Konstruktor
        internal Brains()
            : base(nameof(Brains), 1300, TierEnum.Two, ActionTypeEnum.Full) {
            Name.Set(Util.LanguageEnum.Deutsch, "BRAINZZZZ!");
            Name.Set(Util.LanguageEnum.English, "BRAINZZZZ!");
            Description.Set(Util.LanguageEnum.Deutsch, "");
            Description.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}