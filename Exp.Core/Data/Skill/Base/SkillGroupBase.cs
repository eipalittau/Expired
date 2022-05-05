namespace Exp.Data.Skill {
    public abstract class SkillGroupBase : DataBase {
        #region Properties / Felder
        #endregion

        #region Konstruktor
        protected SkillGroupBase(string aID, int aSortWeight)
            : base(aID, aSortWeight) { }
        #endregion

        #region Methoden
        protected static void AddInstance(ISkillGroupData aInstance) {
            Api.Skill.SkillGroup.Singleton.Add(aInstance);
        }
        #endregion
    }
}