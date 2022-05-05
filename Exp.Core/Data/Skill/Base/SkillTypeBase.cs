namespace Exp.Data.Skill {
    public abstract class SkillTypeBase : DataBase {
        #region Properties / Felder
        public ISkillGroupData Group { get; set; }
        #endregion

        #region Konstruktor
        protected SkillTypeBase(string aID, int aSortWeight, ISkillGroupData aGroup)
            : base(aID, aSortWeight)
            => Group = aGroup;
        #endregion

        #region Methoden
        protected static void AddInstance(ISkillTypeData aInstance) {
            Api.Skill.SkillType.Singleton.Add(aInstance);
        }
        #endregion
    }
}