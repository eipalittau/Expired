namespace Exp.Api.Player.Sheet {
    public sealed class HealthData : SheetBase {
        #region Properties / Felder
        public bool CanOverheal { get; set; }
        #endregion

        #region Konstruktor
        internal HealthData(CharacterSheet aMain)
            : base(aMain) { }
        #endregion

        #region Methoden
        public void OnDamage(int aPoints) {
            base.OnDecrease(aPoints);
        }

        public void OnHeal(int aPoints) {
            base.OnIncrease(aPoints, CanOverheal);
        }
        #endregion
    }
}