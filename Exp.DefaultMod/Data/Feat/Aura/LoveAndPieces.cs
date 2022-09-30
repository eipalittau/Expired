using Exp.Data.Feat.Aura;
using Exp.Util.Enumeration;

namespace Exp.DefaultMod.Feat.Aura
{
    public sealed class LoveAndPieces : AuraDataBase, IAuraData {
        #region Konstruktor
        private LoveAndPieces()
            : base(nameof(LoveAndPieces), 1300, Api.General.Tier.Singleton.Get(nameof(General.Tier.One)), Api.General.ActionType.Singleton.Get(nameof(General.ActionType.Move))) {
            Name.Set(LanguageEnum.Deutsch, "Love and Pieces");
            Name.Set(LanguageEnum.English, "Love and Pieces");
            LoreDescription.Set(LanguageEnum.Deutsch, "");
            LoreDescription.Set(LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new LoveAndPieces());
        }
        #endregion
    }
}