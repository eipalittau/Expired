namespace Exp.Api.Player.Sheet {
    public sealed class HealthData {
        #region Properties / Felder
        public int Max { get; set; }
        public int Current { get; set; }
        public bool Died { get; private set; }
        private bool CanOverheal { get; set; }
        #endregion

        #region Konstruktor
        internal HealthData(bool aCanOverheal)
            => CanOverheal = aCanOverheal;
        #endregion

        #region Methoden
        public void OnDamage(int aPoints) {
            if (!Died) {
                if (Current > aPoints) {
                    Current -= aPoints;
                } else {
                    Current = 0;
                    Died = true;
                }
            }
        }

        public void OnHeal(int aPoints) {
            if (!Died) {
                Current += aPoints;

                if (Current > Max && !CanOverheal) {
                    Current = Max;
                }
            }
        }

        public void OnNewDay() {
            Current = Max;
            Died = false;
        }
        #endregion
    }
}