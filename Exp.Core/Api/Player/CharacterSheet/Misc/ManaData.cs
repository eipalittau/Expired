namespace Exp.Api.Player.Sheet {
    public sealed class ManaData {
        #region Properties / Felder
        public int Max { get; private set; }
        public int Current { get; internal set; }
        public int Temp { get; internal set; }
        #endregion

        #region Konstruktor
        internal ManaData() { }
        #endregion

        #region Methoden
        public void OnConjure(int aPoints) {
            if (Current > aPoints) {
                Current -= aPoints;
            } else {
                Current = 0;
            }
        }

        public void OnRestore(int aPoints) {
            Current += aPoints;

            if (Current > Max + Temp) {
                Current = Max + Temp;
            }
        }
        

        public void OnNewDay() {
            Current = Max + Temp;
        }
        #endregion
    }
}