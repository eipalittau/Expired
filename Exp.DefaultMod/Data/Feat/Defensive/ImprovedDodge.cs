using Exp.Data.Feat;
using Exp.Data.General;

namespace Exp.DefaultMod.Feat.Defensive {
    internal sealed class ImprovedDodge : FeatDataBase<IDefensiveData>, IDefensiveData {
        #region Konstruktor
        internal ImprovedDodge()
            : base(nameof(ImprovedDodge), 1300, TierEnum.Two, null, Api.Feat.Defensive.Singleton.Get("Dodge")) {
            Name.Set(Util.LanguageEnum.Deutsch, "Verbessertes Ausweichen");
            Name.Set(Util.LanguageEnum.English, "Improved dodge");
            Description.Set(Util.LanguageEnum.Deutsch, "");
            Description.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}