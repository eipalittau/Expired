using Exp.Data.Feat;
using Exp.Data.General;

namespace Exp.DefaultMod.Feat.Wonder {
    internal sealed class Mob : FeatDataBase<IWonderData>, IWonderData {
        #region Konstruktor
        internal Mob()
            : base(nameof(Mob), 1200, TierEnum.Two, ActionTypeEnum.Standard) {
            Name.Set(Util.LanguageEnum.Deutsch, "Horde");
            Name.Set(Util.LanguageEnum.English, "Mob");
            Description.Set(Util.LanguageEnum.Deutsch, "");
            Description.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}