using Exp.Data.Feat;
using Exp.Data.General;

namespace Exp.DefaultMod.Feat.Aura {
    internal sealed class LoveAndPieces : FeatDataBase<IAuraData>, IAuraData {
        #region Konstruktor
        internal LoveAndPieces()
            : base(nameof(LoveAndPieces), 1300, TierEnum.One, ActionTypeEnum.Move) {
            Name.Set(Util.LanguageEnum.Deutsch, "Love and Pieces");
            Name.Set(Util.LanguageEnum.English, "Love and Pieces");
            Description.Set(Util.LanguageEnum.Deutsch, "");
            Description.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}