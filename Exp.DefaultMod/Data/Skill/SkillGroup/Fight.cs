using Exp.Data.Skill.SkillGroup;
using Exp.Util.Enumeration;

namespace Exp.DefaultMod.Skill.Group
{
    public sealed class Fight : SkillGroupDataBase, ISkillGroupData {
        #region Konstruktor
        private Fight()
            : base(nameof(Fight), 100) {
            Name.Set(LanguageEnum.Deutsch, "Kampf");
            Name.Set(LanguageEnum.English, "Fight");
            LoreDescription.Set(LanguageEnum.Deutsch, "");
            LoreDescription.Set(LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new Fight());
        }
        #endregion
    }
}