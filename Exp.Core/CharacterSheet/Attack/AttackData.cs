using Exp.Api.General;
using Exp.Data.General.DamageType;
using System.ComponentModel;

namespace Exp.Core.Sheet {
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public sealed class AttackData : DataListBase<AttackItemData> {
        #region Konstruktor
        internal AttackData(CharacterSheet aMain)
            : base() {
            DamageType.Singleton.Enumerate().ToList().ForEach(x => base.Add(new AttackItemData(aMain, x)));
        }
        #endregion

        #region Methoden
        internal AttackItemData Get(IDamageTypeData aDamageType) {
            return base.Get(x => x.DamageType == aDamageType);
        }

        internal void LevelUp() {
            base.LevelUp(TargetEffectEnum.Attack);
        }
        #endregion
    }
}