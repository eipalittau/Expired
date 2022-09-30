using Exp.Data.Skill.SkillGroup;
using Exp.Util.Enumeration;

namespace Exp.DefaultMod.Skill.Group
{
    public sealed class Dungeon : SkillGroupDataBase, ISkillGroupData {
        #region Konstruktor
        private Dungeon()
            : base(nameof(Dungeon), 100) {
            Name.Set(LanguageEnum.Deutsch, "Dungeon");
            Name.Set(LanguageEnum.English, "Dungeon");
            LoreDescription.Set(LanguageEnum.Deutsch, "");
            LoreDescription.Set(LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new Dungeon());
        }
        #endregion
    }
}