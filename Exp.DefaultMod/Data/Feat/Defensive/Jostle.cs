using Exp.Data.Feat;
using Exp.Data.General;

namespace Exp.DefaultMod.Feat.Defensive {
    internal sealed class Jostle : FeatDataBase<IDefensiveData>, IDefensiveData {
        #region Konstruktor
        internal Jostle()
            : base(nameof(Jostle), 100, TierEnum.One, ActionTypeEnum.Free) {
            Name.Set(Util.LanguageEnum.Deutsch, "Schubsen");
            Name.Set(Util.LanguageEnum.English, "Jostle");
            Description.Set(Util.LanguageEnum.Deutsch, "");
            Description.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}