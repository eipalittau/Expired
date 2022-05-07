namespace Exp.Api.Player.Sheet {
    public sealed class FightData {
        #region Properties / Felder
        public int ArmorClass { get; set; }
        public int Resistence { get; set; }
        public int Attack { get; internal set; }
        public bool Damage { get; private set; }
        private bool Sneaky { get; set; }
        #endregion

        #region Konstruktor
        internal FightData() { }
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