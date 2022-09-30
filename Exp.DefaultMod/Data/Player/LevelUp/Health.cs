using Exp.Data.Player.LevelUp;
using Exp.Util.Enumeration;

namespace Exp.DefaultMod.Player.LevelUp
{
    public sealed class Health : LevelUpDataBase, ILevelUpData {
        #region Konstruktor
        private Health()
            : base(Api.General.TargetEffectEnum.Health, new Api.Helper.ModifierData(1, 0, 4)) {
            Name.Set(LanguageEnum.Deutsch, "Fertigkeitspunkte");
            Name.Set(LanguageEnum.English, "Skill points");
            LoreDescription.Set(LanguageEnum.Deutsch, "");
            LoreDescription.Set(LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new Health());
        }
        #endregion
    }
}