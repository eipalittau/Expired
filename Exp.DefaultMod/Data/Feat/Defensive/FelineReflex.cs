using Exp.Data.Feat;
using Exp.Data.General;

namespace Exp.DefaultMod.Feat.Defensive {
    internal sealed class FelineReflex : FeatDataBase<IDefensiveData>, IDefensiveData {
        #region Konstruktor
        internal FelineReflex()
            : base(nameof(FelineReflex), 300, TierEnum.One, null) {
            Name.Set(Util.LanguageEnum.Deutsch, "Katzenreflex");
            Name.Set(Util.LanguageEnum.English, "Feline reflex");
            Description.Set(Util.LanguageEnum.Deutsch, "");
            Description.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}