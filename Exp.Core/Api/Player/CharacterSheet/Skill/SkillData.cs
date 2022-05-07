namespace Exp.Api.Player.Sheet {
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class SkillData {
        #region Properties / Felder
        public Data.Skill.ISkillGroupData SkillGroup { get; init; }
        public IList<SkillTypeData> SkillTypeList { get; } = new List<SkillTypeData>();
        #endregion

        #region Konstruktor
        internal SkillData(Data.Skill.ISkillGroupData aGroup) {
            SkillGroup = aGroup;
            Skill.SkillType.Singleton.Enumerate(aGroup).ToList().ForEach(x => SkillTypeList.Add(new SkillTypeData(x)));
        }
        #endregion
    }
}