using Exp.Data.Feat;
using Exp.Data.General;

namespace Exp.DefaultMod.Feat.Wizardry {
    internal sealed class Reflection : FeatDataBase<IWizardryData>, IWizardryData {
        #region Konstruktor
        internal Reflection()
            : base(nameof(Reflection), 300, TierEnum.One, ActionTypeEnum.Standard) {
            Name.Set(Util.LanguageEnum.Deutsch, "Spiegelbild");
            Name.Set(Util.LanguageEnum.English, "Reflection");
            Description.Set(Util.LanguageEnum.Deutsch, "");
            Description.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}