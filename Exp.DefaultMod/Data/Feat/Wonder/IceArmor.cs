using Exp.Data.Feat;
using Exp.Data.General;

namespace Exp.DefaultMod.Feat.Wonder {
    internal sealed class IceArmor : FeatDataBase<IWonderData>, IWonderData {
        #region Konstruktor
        internal IceArmor()
            : base(nameof(IceArmor), 100, TierEnum.One, null) {
            Name.Set(Util.LanguageEnum.Deutsch, "Eisrüstung");
            Name.Set(Util.LanguageEnum.English, "Ice armor");
            Description.Set(Util.LanguageEnum.Deutsch, "");
            Description.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}