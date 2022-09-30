using Exp.Data.Skill.SkillType;
using Exp.Util.Enumeration;

namespace Exp.DefaultMod.Skill.Type
{
    public sealed class Detection : SkillTypeDataBase, ISkillTypeData {
        #region Konstruktor
        private Detection()
            : base(nameof(Detection), 100, Api.Skill.SkillGroup.Singleton.Get(nameof(Skill.Group.Dungeon))) {
            Name.Set(LanguageEnum.Deutsch, "Wahrnehmung");
            Name.Set(LanguageEnum.English, "Detection");
            LoreDescription.Set(LanguageEnum.Deutsch, "");
            LoreDescription.Set(LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new Detection());
        }
        #endregion
    }
}