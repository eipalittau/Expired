using Exp.Data.Skill.SkillType;
using System.ComponentModel;

namespace Exp.Core.Sheet {
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public sealed class SkillItemData : SheetBase {
        #region Properties / Felder
        public ISkillTypeData SkillType { get; init; }
        #endregion

        #region Konstruktor
        internal SkillItemData(CharacterSheet aMain, ISkillTypeData aSkillType, int aMaxLevel)
            : base(aMain)
            => (SkillType, base.Max) = (aSkillType, aMaxLevel);

        internal bool LevelUp() {
            if (base.Current == base.Max) {
                Util.ExceptionHandler.Add(new Exception.MaximumExceededException(SkillType.ID, base.Max));
                return false;
            } else {
                base.OnIncrease();
                return true;
            }
        }
        #endregion
    }
}