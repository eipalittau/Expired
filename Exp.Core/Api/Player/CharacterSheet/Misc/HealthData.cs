namespace Exp.Api.Player.Sheet {
    public sealed class HealthData {
        #region Properties / Felder
        public int Max { get; internal set; }
        public int Current { get; private set; }
        public int Temp { get; private set; }
        public bool Died { get; private set; }
        private bool CanOverheal { get; set; }
        #endregion

        #region Konstruktor
        internal HealthData() { }
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

                if (Current > Max + Temp && !CanOverheal) {
                    Current = Max + Temp;
                }
            }
        }

        public void OnNewDay() {
            Current = Max + Temp;
            Died = false;
        }
        #endregion
    }
}