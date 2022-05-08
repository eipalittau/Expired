namespace Exp.Api.Player.Sheet {
    public sealed class ManaData : SheetBase {
        #region Properties / Felder
        #endregion

        #region Konstruktor
        internal ManaData(CharacterSheet aMain) 
            : base(aMain) { }
        #endregion

        #region Methoden
        public void OnConjure(int aPoints) {
            base.OnDecrease(aPoints);
        }

        public void OnRestore(int aPoints) {
            base.OnIncrease(aPoints, false);
        }
        #endregion
    }
}