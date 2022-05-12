namespace Exp.Api.Helper {
    public sealed class ModifierData {
        #region Properties / Felder
        public int Value { get; set; }
        public IntervallData Intervall { get; } = new();
        public bool HasData { 
            get {
                return (Value > 0 && Value < int.MaxValue)
                    && (Intervall.Level >= 0 && Intervall.Level < int.MaxValue)
                    && (Intervall.Day >= 0 && Intervall.Day < int.MaxValue);
            } 
        }
        #endregion

        #region Konstruktor
        public ModifierData(int aIntervallLevel, int aIntervallDay, int aValue)
            => (Intervall.Level, Intervall.Day, Value) = (aIntervallLevel, aIntervallDay, aValue);
        #endregion

        #region Methoden
        public int GetValueByLevel(int aLevel) {
            return Value * ((int)Math.Floor((double)aLevel / Intervall.Level) + 1);
        }
        #endregion

        public sealed class IntervallData {
            #region Properties / Felder
            /// <summary>
            /// IntervallLevel = 0: Einmalige Modifikation.
            /// IntervallLevel = 1: Modifier pro Stufe.
            /// IntervallLevel = N: Modifier pro N Stufen.
            /// </summary>
            public int Level { get; set; }
            /// <summary>
            /// IntervallDay = 0: Keine Einschränkung.
            /// IntervallDay = 1: 1x pro Tag.
            /// IntervallDay = N: Nx pro Tag.
            /// </summary>
            public int Day { get; set; }
            #endregion

            #region Konstruktor
            internal IntervallData() { }
            #endregion
        }
    }
}