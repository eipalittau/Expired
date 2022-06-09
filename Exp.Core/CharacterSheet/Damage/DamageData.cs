using Exp.Api.General;
using Exp.Data.General.DamageType;
using System.ComponentModel;

namespace Exp.Core.Sheet {
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public sealed class DamageData : DataListBase<DamageItemData> {
        #region Konstruktor
        internal DamageData(CharacterSheet aMain)
            : base() {
            DamageType.Singleton.Enumerate().ToList().ForEach(x => new DamageItemData(aMain, x));
        }
        #endregion

        #region Methoden
        internal DamageItemData Get(IDamageTypeData aDamageType) {
            return base.Get(x => x.DamageType == aDamageType);
        }

        internal void LevelUp() {
            base.LevelUp(TargetEffectEnum.Damage);
        }
        #endregion
    }
}