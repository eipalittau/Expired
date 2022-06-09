using Exp.Api.General;
using Exp.Data.Skill.SkillType;
using System.ComponentModel;

namespace Exp.Core.Sheet {
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public sealed class SkillData : DataListBase<SkillItemData> {
        #region Properties / Felder
        public int AvailableSkillPoints { get; internal set; }
        #endregion

        #region Konstruktor
        internal SkillData(CharacterSheet aMain, int aMaxLevel) {
            Api.Skill.SkillType.Singleton.Enumerate().ToList()
                .ForEach(x => base.Add(new SkillItemData(aMain, x, aMaxLevel)));
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
                SkillItemData lItem = base.Get(x => x.SkillType == aSkillType);

                if (lItem == null) {
                    Util.ExceptionHandler.Add(new Exception.ItemNotFoundException(aSkillType.ID));
                } else {
                    lResult = lItem.LevelUp();
                    AvailableSkillPoints--;
                }
            }

            return lResult;
        }
        #endregion
    }
}