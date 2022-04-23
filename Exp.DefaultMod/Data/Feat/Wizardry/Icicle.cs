using Exp.Data.Feat;
using Exp.Data.General;

namespace Exp.DefaultMod.Feat.Wizardry {
    internal sealed class Icicle : FeatDataBase<IWizardryData>, IWizardryData {
        #region Konstruktor
        internal Icicle()
            : base(nameof(Icicle), 900, TierEnum.Two, ActionTypeEnum.Move) {
            Name.Set(Util.LanguageEnum.Deutsch, "Eiszapfen");
            Name.Set(Util.LanguageEnum.English, "Icicle");
            Description.Set(Util.LanguageEnum.Deutsch, "");
            Description.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}