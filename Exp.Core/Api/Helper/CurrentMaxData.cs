namespace Exp.Api.Helper {
    public sealed class CurrentMaxData {
        #region Properties / Felder
        public int Max { get; set; }
        public int Current { get; set; }
        #endregion

        #region Konstruktor
        public CurrentMaxData() { }

        public CurrentMaxData(int aMax)
            : this(aMax, aMax) { }
        
        public CurrentMaxData(int aCurrent, int aMax)
            => (Current, Max) = (aCurrent, aMax);
        #endregion

        #region Methoden
        public void OnDecrease(int aPoints) {
            Current -= aPoints;

            if (Current < 0) {
                Current = 0;
            }
        }

        public void OnIncrease(int aPoints) {
            Current += aPoints;

            if (Current > Max) {
                Current = Max;
            }
        }

        public void OnNewDay() {
            Current = Max;
        }
        #endregion
    }
}