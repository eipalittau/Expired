using Exp.Api.General;
using Exp.Data.Skill.SkillType;

namespace Exp.Core.Sheet {
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class SkillData {
        #region Properties / Felder
        public IList<SkillItemData> SkillList { get; } = new List<SkillItemData>();
        public int AvailableSkillPoints { get; internal set; }
        #endregion

        #region Konstruktor
        internal SkillData(int aMaxLevel) {
            Api.Skill.SkillType.Singleton.Enumerate().ToList()
                .ForEach(x => SkillList.Add(new SkillItemData(x, aMaxLevel)));
        }
        #endregion

        #region Methoden
        internal void SetSkillPoints() {
            if (Api.Player.LevelUp.Singleton.Contains(TargetEffectEnum.SkillPoints)) {
                AvailableSkillPoints = Api.Player.LevelUp.Singleton.Get(TargetEffectEnum.SkillPoints).Base.Value;
            }
        }

        internal bool LevelUp(ISkillTypeData aSkillType) {
            bool lResult = false;

            if (AvailableSkillPoints > 0) {
                IEnumerable<SkillItemData> lItem = SkillList.Where(x => x.SkillType == aSkillType);

                if (lItem.Any()) {
                    lResult = lItem.First().LevelUp();
                    AvailableSkillPoints--;
                } else {
                    Util.ExceptionHandler.Add(new Exception.ItemNotFoundException(aSkillType.ID));
                }
            }

            return lResult;
        }
        #endregion
    }
}