using Exp.Data.Feat;
using Exp.Data.General;

namespace Exp.DefaultMod.Feat.Wizardry {
    internal sealed class Fireball : FeatDataBase<IWizardryData>, IWizardryData {
        #region Konstruktor
        internal Fireball()
            : base(nameof(Fireball), 1000, TierEnum.Two, ActionTypeEnum.Standard) {
            Name.Set(Util.LanguageEnum.Deutsch, "Feuerball");
            Name.Set(Util.LanguageEnum.English, "Fireball");
            Description.Set(Util.LanguageEnum.Deutsch, "");
            Description.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}