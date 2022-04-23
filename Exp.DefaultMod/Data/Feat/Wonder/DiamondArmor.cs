using Exp.Data.Feat;
using Exp.Data.General;

namespace Exp.DefaultMod.Feat.Wonder {
    internal sealed class DiamondArmor : FeatDataBase<IWonderData>, IWonderData {
        #region Konstruktor
        internal DiamondArmor()
            : base(nameof(DiamondArmor), 900, TierEnum.Two, null) {
            Name.Set(Util.LanguageEnum.Deutsch, "Diamantrüstung");
            Name.Set(Util.LanguageEnum.English, "Diamond armor");
            Description.Set(Util.LanguageEnum.Deutsch, "");
            Description.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}