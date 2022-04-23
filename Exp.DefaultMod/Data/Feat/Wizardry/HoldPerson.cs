using Exp.Data.Feat;
using Exp.Data.General;

namespace Exp.DefaultMod.Feat.Wizardry {
    internal sealed class HoldPerson : FeatDataBase<IWizardryData>, IWizardryData {
        #region Konstruktor
        internal HoldPerson()
            : base(nameof(HoldPerson), 1100, TierEnum.Two, ActionTypeEnum.Standard) {
            Name.Set(Util.LanguageEnum.Deutsch, "Person festhalten");
            Name.Set(Util.LanguageEnum.English, "Hold person");
            Description.Set(Util.LanguageEnum.Deutsch, "");
            Description.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}