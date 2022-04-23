using Exp.Data.Feat;
using Exp.Data.General;

namespace Exp.DefaultMod.Feat.Aura {
    internal sealed class Reflexes : FeatDataBase<IAuraData>, IAuraData {
        #region Konstruktor
        internal Reflexes()
            : base(nameof(Reflexes), 400, TierEnum.One, null) {
            Name.Set(Util.LanguageEnum.Deutsch, "Aura der Reflexe");
            Name.Set(Util.LanguageEnum.English, "Aura of reflexes");
            Description.Set(Util.LanguageEnum.Deutsch, "");
            Description.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}