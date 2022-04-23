using Exp.Data.Feat;
using Exp.Data.General;

namespace Exp.DefaultMod.Feat.Wonder {
    internal sealed class AccurateWeapon : FeatDataBase<IWonderData>, IWonderData {
        #region Konstruktor
        internal AccurateWeapon()
            : base(nameof(AccurateWeapon), 1000, TierEnum.Two, null) {
            Name.Set(Util.LanguageEnum.Deutsch, "Zielsichere Waffe");
            Name.Set(Util.LanguageEnum.English, "Accurate weapon");
            Description.Set(Util.LanguageEnum.Deutsch, "");
            Description.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}