using Exp.Data.Skill.SkillType;

namespace Exp.Api.Player.Sheet {
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class SkillData {
        #region Properties / Felder
        public int Level { get; set; } = 0;
        public int MaxLevel { get; set; } = int.MaxValue;
        public ISkillTypeData SkillType { get; init; }
        #endregion

        #region Konstruktor
        internal SkillData(ISkillTypeData aSkillType) {
            SkillType = aSkillType;
        }

        internal void LevelUp() {
            if (Level == MaxLevel) {
                Util.ExceptionHandler.Add(new Exception.MaximumExceededException(SkillType.ID, MaxLevel));
            } else {
                Level++;
            }
        }
        #endregion
    }
}