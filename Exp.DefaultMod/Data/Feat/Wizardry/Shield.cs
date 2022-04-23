using Exp.Data.Feat;
using Exp.Data.General;

namespace Exp.DefaultMod.Feat.Wizardry {
    internal sealed class Shield : FeatDataBase<IWizardryData>, IWizardryData {
        #region Konstruktor
        internal Shield()
            : base(nameof(Shield), 400, TierEnum.One, ActionTypeEnum.Free) {
            Name.Set(Util.LanguageEnum.Deutsch, "Schild");
            Name.Set(Util.LanguageEnum.English, "Shield");
            Description.Set(Util.LanguageEnum.Deutsch, "");
            Description.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}