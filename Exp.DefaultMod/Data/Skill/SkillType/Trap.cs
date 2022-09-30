using Exp.Data.Skill.SkillType;
using Exp.Util.Enumeration;

namespace Exp.DefaultMod.Skill.Type
{
    public sealed class Trap : SkillTypeDataBase, ISkillTypeData {
        #region Konstruktor
        private Trap()
            : base(nameof(Trap), 200, Api.Skill.SkillGroup.Singleton.Get(nameof(Skill.Group.Dungeon))) {
            Name.Set(LanguageEnum.Deutsch, "Fallen");
            Name.Set(LanguageEnum.English, "Trap");
            LoreDescription.Set(LanguageEnum.Deutsch, "");
            LoreDescription.Set(LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new Trap());
        }
        #endregion
    }
}