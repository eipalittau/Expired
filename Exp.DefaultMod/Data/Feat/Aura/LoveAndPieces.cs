namespace Exp.DefaultMod.Feat.Aura {
    public sealed class LoveAndPieces : Exp.Data.Feat.AuraDataBase, Exp.Data.Feat.IAuraData {
        #region Konstruktor
        private LoveAndPieces()
            : base(nameof(LoveAndPieces), 1300, Api.General.Tier.Singleton.Get(nameof(General.Tier.One)), Api.General.ActionType.Singleton.Get(nameof(General.ActionType.Move))) {
            Name.Set(Util.LanguageEnum.Deutsch, "Love and Pieces");
            Name.Set(Util.LanguageEnum.English, "Love and Pieces");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new LoveAndPieces());
        }
        #endregion
    }
}