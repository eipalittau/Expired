using Exp.Data.Feat;
using Exp.Data.General;

namespace Exp.DefaultMod.Feat.Wizardry {
    internal sealed class Fright : FeatDataBase<IWizardryData>, IWizardryData {
        #region Konstruktor
        internal Fright()
            : base(nameof(Fright), 500, TierEnum.One, ActionTypeEnum.Standard) {
            Name.Set(Util.LanguageEnum.Deutsch, "Schreck");
            Name.Set(Util.LanguageEnum.English, "Fright");
            Description.Set(Util.LanguageEnum.Deutsch, "");
            Description.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}