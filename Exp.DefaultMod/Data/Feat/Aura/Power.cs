using Exp.Data.Feat;
using Exp.Data.General;

namespace Exp.DefaultMod.Feat.Aura {
    internal sealed class Power : FeatDataBase<IAuraData>, IAuraData {
        #region Konstruktor
        internal Power()
            : base(nameof(Power), 200, TierEnum.One, null) {
            Name.Set(Util.LanguageEnum.Deutsch, "Aura der Macht");
            Name.Set(Util.LanguageEnum.English, "Aura of power");
            Description.Set(Util.LanguageEnum.Deutsch, "");
            Description.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}