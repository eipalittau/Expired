using Exp.Api.General;
using Exp.Data.General.DamageType;

namespace Exp.Core.Sheet {
    public sealed class DamageItemData : SheetBase {
        #region Properties / Felder
        public IDamageTypeData DamageType { get; init; }
        #endregion

        #region Konstruktor
        internal DamageItemData(CharacterSheet aMain, IDamageTypeData aDamageType)
            : base(aMain) {
            DamageType = aDamageType;
        }
        #endregion

        #region Methoden
        internal bool LevelUp() {
            return base.LevelUp(TargetEffectEnum.Damage);
        }
        #endregion
    }
}