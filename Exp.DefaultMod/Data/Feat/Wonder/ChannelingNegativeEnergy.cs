using Exp.Data.Feat;
using Exp.Data.General;

namespace Exp.DefaultMod.Feat.Wonder {
    internal sealed class ChannelingNegativeEnergy : FeatDataBase<IWonderData>, IWonderData {
        #region Konstruktor
        internal ChannelingNegativeEnergy()
            : base(nameof(ChannelingNegativeEnergy), 1100, TierEnum.Two, ActionTypeEnum.Standard) {
            Name.Set(Util.LanguageEnum.Deutsch, "Negative Energie Kanalisieren");
            Name.Set(Util.LanguageEnum.English, "Channeling negative energy");
            Description.Set(Util.LanguageEnum.Deutsch, "");
            Description.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}