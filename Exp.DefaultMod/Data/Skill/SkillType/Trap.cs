namespace Exp.DefaultMod.Skill.Type {
    public sealed class Trap : Exp.Data.Skill.SkillTypeDataBase, Exp.Data.Skill.ISkillTypeData {
        #region Konstruktor
        private Trap()
            : base(nameof(Trap), 200, Api.Skill.SkillGroup.Singleton.Get(nameof(Skill.Group.Dungeon))) {
            Name.Set(Util.LanguageEnum.Deutsch, "Fallen");
            Name.Set(Util.LanguageEnum.English, "Trap");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new Trap());
        }
        #endregion
    }
}