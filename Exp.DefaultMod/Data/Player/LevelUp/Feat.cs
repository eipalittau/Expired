using Exp.Data.Player.LevelUp;
using Exp.Util.Enumeration;

namespace Exp.DefaultMod.Player.LevelUp
{
    public sealed class Feat : LevelUpDataBase, ILevelUpData {
        #region Konstruktor
        private Feat()
            : base(Api.General.TargetEffectEnum.FeatPoints, new Api.Helper.ModifierData(1, 0, 1)) {
            Name.Set(LanguageEnum.Deutsch, "Attributspunkte");
            Name.Set(LanguageEnum.English, "Feat points");
            LoreDescription.Set(LanguageEnum.Deutsch, "");
            LoreDescription.Set(LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new Feat());
        }
        #endregion
    }
}