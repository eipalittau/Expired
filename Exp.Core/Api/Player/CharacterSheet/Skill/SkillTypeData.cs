namespace Exp.Api.Player.Sheet {
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class SkillTypeData {
        #region Properties / Felder
        public int Level { get; set; } = 0;
        public int MaxLevel { get; set; } = int.MaxValue;
        public Data.Skill.ISkillTypeData SkillType { get; init; }
        #endregion

        #region Konstruktor
        internal SkillTypeData(Data.Skill.ISkillTypeData aSkillType) {
            SkillType = aSkillType;
        }

        internal void LevelUp() {
            if (Level == MaxLevel) {
                throw new Exception.MaximumExceededException(SkillType.ID, MaxLevel);
            }

            Level++;
        }
        #endregion
    }
}