using Exp.Data.Feat;
using Exp.Data.General;

namespace Exp.DefaultMod.Feat.Wonder {
    internal sealed class MagicWeapon : FeatDataBase<IWonderData>, IWonderData {
        #region Konstruktor
        internal MagicWeapon()
            : base(nameof(MagicWeapon), 200, TierEnum.One, ActionTypeEnum.Standard) {
            Name.Set(Util.LanguageEnum.Deutsch, "Magische Waffe");
            Name.Set(Util.LanguageEnum.English, "Magic weapon");
            Description.Set(Util.LanguageEnum.Deutsch, "");
            Description.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}