using Exp.Data.Player.LevelUp;
using Exp.Util.Enumeration;

namespace Exp.DefaultMod.Player.LevelUp
{
    public sealed class Movement : LevelUpDataBase, ILevelUpData {
        #region Konstruktor
        private Movement()
            : base(Api.General.TargetEffectEnum.Movement, new Api.Helper.ModifierData(0, 0, 4)) {
            Name.Set(LanguageEnum.Deutsch, "Bewegungsrate");
            Name.Set(LanguageEnum.English, "Movement rate");
            LoreDescription.Set(LanguageEnum.Deutsch, "");
            LoreDescription.Set(LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new Movement());
        }
        #endregion
    }
}