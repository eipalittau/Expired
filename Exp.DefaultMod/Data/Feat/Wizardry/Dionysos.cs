using Exp.Data.Feat;
using Exp.Data.General;

namespace Exp.DefaultMod.Feat.Wizardry {
    internal sealed class Dionysos : FeatDataBase<IWizardryData>, IWizardryData {
        #region Konstruktor
        internal Dionysos()
            : base(nameof(Dionysos), 1700, TierEnum.Three, ActionTypeEnum.Standard) {
            Name.Set(Util.LanguageEnum.Deutsch, "Dionysos");
            Name.Set(Util.LanguageEnum.English, "Dionysos");
            Description.Set(Util.LanguageEnum.Deutsch, "");
            Description.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}