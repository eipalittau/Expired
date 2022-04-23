using Exp.Data.Feat;
using Exp.Data.General;

namespace Exp.DefaultMod.Feat.Wizardry {
    internal sealed class Metamagic : FeatDataBase<IWizardryData>, IWizardryData {
        #region Konstruktor
        internal Metamagic()
            : base(nameof(Metamagic), 1200, TierEnum.Two, null) {
            Name.Set(Util.LanguageEnum.Deutsch, "Metamagie");
            Name.Set(Util.LanguageEnum.English, "Metamagic");
            Description.Set(Util.LanguageEnum.Deutsch, "");
            Description.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}