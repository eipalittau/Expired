namespace Exp.Api.Player.Sheet {
    public sealed class ConjureData {
        #region Properties / Felder
        public int Conjure { get; internal set; }
        public ManaData Mana { get; init; }
        #endregion

        #region Konstruktor
        internal ConjureData(CharacterSheet aMain)
            => Mana = new ManaData(aMain);
        #endregion

        #region Methoden
        internal void OnNewDay() {
            Mana.OnNewDay();
        }
        #endregion
    }
}