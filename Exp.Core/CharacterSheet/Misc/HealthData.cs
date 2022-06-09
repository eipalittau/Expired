using Exp.Api.General;
using System.ComponentModel;

namespace Exp.Core.Sheet {
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public sealed class HealthData : SheetBase {
        #region Properties / Felder
        public bool CanOverheal { get; set; }
        #endregion

        #region Konstruktor
        internal HealthData(CharacterSheet aMain)
            : base(aMain) {
            CanOverheal = aMain.PlayerClass.AptitudeList.Any(x => x.Effect.Equals(TargetEffectEnum.Overheal));
        }
        #endregion

        #region Methoden
        internal void LevelUp() {
            base.LevelUp(TargetEffectEnum.Health);
        }

        public void OnDamage(int aPoints) {
            base.OnDecrease(aPoints, true);
        }

        public void OnHeal(int aPoints) {
            base.OnIncrease(aPoints, CanOverheal);
        }
        #endregion
    }
}