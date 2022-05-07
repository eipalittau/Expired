namespace Exp.Api.Player.Sheet {
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class SkillTypeData {
        #region Properties / Felder
        public int Level { get; set; } = 0;
        public int MaxLevel { get; set; } = 5;
        public Data.Skill.ISkillTypeData SkillType { get; init; }
        #endregion

        #region Konstruktor
        internal SkillTypeData(Data.Skill.ISkillTypeData aSkillType) {
            SkillType = aSkillType;
        }
        #endregion
    }
}