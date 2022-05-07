namespace Exp.Data.Misc {
    public sealed class ModifierData {
        #region Properties / Felder
        private int _Value = int.MinValue;
        public int Value { 
            get {
                return _Value;
            }
            set {
                _Value = value;
                SetHasData();
            }
        }
        private int _Intervall = int.MinValue;
        /// <summary>
        /// Intervall = 0: Einmalige Modifikation.
        /// Intervall = 1: Modifier pro Stufe.
        /// Intervall = N: Modifier pro N Stufen.
        /// </summary>
        public int Intervall {
            get {
                return _Intervall;
            }

            set {
                _Intervall = value;
                SetHasData();
            }
        }
        public bool HasData { get; private set; } = false;
        #endregion

        #region Konstruktor
        public ModifierData(int aIntervall, int aValue)
            => (Intervall, Value) = (aIntervall, aValue);
        #endregion

        #region Methoden
        private void SetHasData() {
            HasData = (_Value > 0 && _Value < int.MaxValue) && (_Intervall >= 0 && _Intervall < int.MaxValue);
        }
        #endregion
    }
}