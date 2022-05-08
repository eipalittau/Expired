namespace Exp.Api.Player.Sheet {
    public abstract class SheetBase {
        #region Properties / Felder
        public int Max { get; internal set; }
        public int Current { get; private set; }
        public int Temp { get; internal set; }
        internal CharacterSheet Main { get; init; }
        #endregion

        #region Konstruktor
        private protected SheetBase(CharacterSheet aMain)
            => Main = aMain;
        #endregion

        #region Methoden
        private protected void OnDecrease(int aPoints) {
            if (!Main.IsDead) {
                if (Current > aPoints) {
                    Current -= aPoints;
                } else {
                    Current = 0;
                    Main.IsDead = true;
                }
            }
        }

        private protected void OnIncrease(int aPoints) {
            OnIncrease(aPoints, false);
        }

        private protected void OnIncrease(int aPoints, bool aForceOverMax) {
            if (!Main.IsDead) {
                Current += aPoints;

                if (Current > Max + Temp && !aForceOverMax) {
                    Current = Max + Temp;
                }
            }
        }

        internal void OnNewDay() {
            Current = Max + Temp;
        }
        #endregion
    }
}