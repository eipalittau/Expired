using Exp.Data.Player.LevelUp;
using Exp.Util.Enumeration;

namespace Exp.DefaultMod.Player.LevelUp
{
    public sealed class Skill : LevelUpDataBase, ILevelUpData {
        #region Konstruktor
        private Skill()
            : base(Api.General.TargetEffectEnum.SkillPoints, new Api.Helper.ModifierData(1, 0, 2)) {
            Name.Set(LanguageEnum.Deutsch, "Fertigkeitspunkte");
            Name.Set(LanguageEnum.English, "Skill points");
            LoreDescription.Set(LanguageEnum.Deutsch, "");
            LoreDescription.Set(LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new Skill());
        }
        #endregion
    }
}