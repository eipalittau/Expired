namespace Exp.Data.Skill.SkillType {
    public sealed class None : SkillTypeDataBase, ISkillTypeData {
        #region Konstruktor
        private None()
            : base(Core.Properties.Resources.NameDefaultObject, int.MinValue, Api.Skill.SkillGroup.Singleton.Get(Core.Properties.Resources.NameDefaultObject)) {
            foreach (Util.LanguageEnum lItem in Util.LanguageEnum.Enumerate()) {
                Name.Set(lItem, Core.Properties.Resources.NameDefaultObject);
                LoreDescription.Set(lItem, Core.Properties.Resources.NameDefaultObject);
            }
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new None());
        }
        #endregion
    }
}