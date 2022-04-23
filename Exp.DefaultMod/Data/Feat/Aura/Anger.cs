using Exp.Data.Feat;
using Exp.Data.General;

namespace Exp.DefaultMod.Feat.Aura {
    internal sealed class Anger : FeatDataBase<IAuraData>, IAuraData {
        #region Konstruktor
        internal Anger()
            : base(nameof(Anger), 600, TierEnum.One,null, Api.Feat.Aura.Singleton.Get(nameof(Fencer)), Api.Feat.Aura.Singleton.Get(nameof(Power))) {
            Name.Set(Util.LanguageEnum.Deutsch, "Aura des Zorns");
            Name.Set(Util.LanguageEnum.English, "Aura of anger");
            Description.Set(Util.LanguageEnum.Deutsch, "");
            Description.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}