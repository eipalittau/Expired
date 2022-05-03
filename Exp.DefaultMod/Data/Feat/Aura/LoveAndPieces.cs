using Exp.Data.Feat;

namespace Exp.DefaultMod.Feat.Aura {
    internal sealed class LoveAndPieces : AuraDataBase, IAuraData {
        #region Konstruktor
        internal LoveAndPieces()
            : base(nameof(LoveAndPieces), 1300, Api.General.Tier.Singleton.Get(nameof(General.Tier.One)), Api.General.ActionType.Singleton.Get(nameof(General.ActionType.Move))) {
            Name.Set(Util.LanguageEnum.Deutsch, "Love and Pieces");
            Name.Set(Util.LanguageEnum.English, "Love and Pieces");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}