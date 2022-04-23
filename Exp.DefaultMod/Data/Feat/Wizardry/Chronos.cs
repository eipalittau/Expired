using Exp.Data.Feat;
using Exp.Data.General;

namespace Exp.DefaultMod.Feat.Wizardry {
    internal sealed class Chronos : FeatDataBase<IWizardryData>, IWizardryData {
        #region Konstruktor
        internal Chronos()
            : base(nameof(Chronos), 1600, TierEnum.Three, ActionTypeEnum.Free) {
            Name.Set(Util.LanguageEnum.Deutsch, "Chronos");
            Name.Set(Util.LanguageEnum.English, "Chronos");
            Description.Set(Util.LanguageEnum.Deutsch, "");
            Description.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}