using Exp.Api.General;
using Exp.Data.General.DamageType;

namespace Exp.Core.Sheet {
    public sealed class AttackItemData : SheetBase {
        #region Properties / Felder
        public IDamageTypeData DamageType { get; init; }
        #endregion

        #region Konstruktor
        internal AttackItemData(CharacterSheet aMain, IDamageTypeData aDamageType)
            : base(aMain) {
            DamageType = aDamageType;
        }
        #endregion

        #region Methoden
        internal bool LevelUp() {
            return base.LevelUp(TargetEffectEnum.Attack);
        }
        #endregion
    }
}