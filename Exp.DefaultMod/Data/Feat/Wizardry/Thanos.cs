using Exp.Data.Feat;
using Exp.Data.General;

namespace Exp.DefaultMod.Feat.Wizardry {
    internal sealed class Thanos : FeatDataBase<IWizardryData>, IWizardryData {
        #region Konstruktor
        internal Thanos()
            : base(nameof(Thanos), 1800, TierEnum.Three, ActionTypeEnum.Standard) {
            Name.Set(Util.LanguageEnum.Deutsch, "Thanos");
            Name.Set(Util.LanguageEnum.English, "Thanos");
            Description.Set(Util.LanguageEnum.Deutsch, "");
            Description.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}