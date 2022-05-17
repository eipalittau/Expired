using Exp.Data.Skill.SkillGroup;

namespace Exp.DefaultMod.Skill.Group {
    public sealed class Fight : SkillGroupDataBase, ISkillGroupData {
        #region Konstruktor
        private Fight()
            : base(nameof(Fight), 100) {
            Name.Set(Util.LanguageEnum.Deutsch, "Kampf");
            Name.Set(Util.LanguageEnum.English, "Fight");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new Fight());
        }
        #endregion
    }
}