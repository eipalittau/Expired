using Exp.Data.Skill.SkillType;

namespace Exp.DefaultMod.Skill.Type {
    public sealed class Detection : SkillTypeDataBase, ISkillTypeData {
        #region Konstruktor
        private Detection()
            : base(nameof(Detection), 100, Api.Skill.SkillGroup.Singleton.Get(nameof(Skill.Group.Dungeon))) {
            Name.Set(Util.LanguageEnum.Deutsch, "Wahrnehmung");
            Name.Set(Util.LanguageEnum.English, "Detection");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new Detection());
        }
        #endregion
    }
}