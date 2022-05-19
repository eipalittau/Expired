namespace Exp.Data.Skill.SkillGroup {
    public abstract class SkillGroupDataBase : DataBase {
        #region Properties / Felder
        #endregion

        #region Konstruktor
        protected SkillGroupDataBase(string aID, int aSortWeight)
            : base(aID, aSortWeight) { }
        #endregion

        #region Methoden
        protected static void AddInstance(ISkillGroupData aInstance) {
            Api.Skill.SkillGroup.Singleton.Add(aInstance);
        }
        #endregion
    }
}