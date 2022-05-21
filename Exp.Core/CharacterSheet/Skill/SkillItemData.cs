using Exp.Data.Skill.SkillType;

namespace Exp.Core.Sheet {
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class SkillItemData {
        #region Properties / Felder
        public int Level { get; private set; }
        public int MaxLevel { get; init; }
        public ISkillTypeData SkillType { get; init; }
        #endregion

        #region Konstruktor
        internal SkillItemData(ISkillTypeData aSkillType, int aMaxLevel)
            => (SkillType, MaxLevel) = (aSkillType, aMaxLevel);

        internal bool LevelUp() {
            if (Level == MaxLevel) {
                Util.ExceptionHandler.Add(new Exception.MaximumExceededException(SkillType.ID, MaxLevel));
                return false;
            } else {
                Level++;
                return true;
            }
        }
        #endregion
    }
}