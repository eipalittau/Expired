using Exp.Data.Skill.SkillGroup;

namespace Exp.DefaultMod.Skill.Group {
    public sealed class Dungeon : SkillGroupDataBase, ISkillGroupData {
        #region Konstruktor
        private Dungeon()
            : base(nameof(Dungeon), 100) {
            Name.Set(Util.LanguageEnum.Deutsch, "Dungeon");
            Name.Set(Util.LanguageEnum.English, "Dungeon");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new Dungeon());
        }
        #endregion
    }
}