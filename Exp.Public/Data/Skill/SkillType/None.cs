using Exp.Util.Enumeration;

namespace Exp.Data.Skill.SkillType
{
    public sealed class None : SkillTypeDataBase, ISkillTypeData {
        #region Konstruktor
        private None()
            : base(Public.Properties.Resources.NameDefaultObject, int.MinValue, Api.Skill.SkillGroup.Singleton.Get(Public.Properties.Resources.NameDefaultObject)) {
            foreach (LanguageEnum lItem in LanguageEnum.Enumerate()) {
                Name.Set(lItem, Public.Properties.Resources.NameDefaultObject);
                LoreDescription.Set(lItem, Public.Properties.Resources.NameDefaultObject);
            }
        }
        #endregion

        #region Methoden
        internal static void Add() {
            AddInstance(new None());
        }
        #endregion
    }
}