namespace Exp.Core.Sheet {
    public abstract class SheetBase {
        #region Properties / Felder
        public int Max { get; internal set; }
        public int Current { get; private set; }
        public int Temp { get; internal set; }
        internal CharacterSheet Main { get; init; }
        private bool IgnoreDeath { get; init; }
        #endregion

        #region Konstruktor0
        private protected SheetBase(CharacterSheet aMain)
            : this(aMain, false) { }

        private protected SheetBase(CharacterSheet aMain, bool aIgnoreDeath)
            => (Main, IgnoreDeath) = (aMain, aIgnoreDeath);
        #endregion

        #region Methoden
        private protected void OnDecrease(int aPoints) {
            OnDecrease(aPoints, false);
        }

        private protected void OnDecrease(int aPoints, bool aCanDie) {
            if (Current > aPoints) {
                Current -= aPoints;
            } else {
                Current = 0;
                if (aCanDie) {
                    Main.IsDead = true;
                }
            }
        }

        private protected void OnIncrease(int aPoints) {
            OnIncrease(aPoints, false);
        }

        private protected void OnIncrease(int aPoints, bool aForceOverMax) {
            if (!Main.IsDead || IgnoreDeath) {
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