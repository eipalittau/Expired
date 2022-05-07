namespace Exp.Api.Player.Sheet {
    public sealed class ConjureData {
        #region Properties / Felder
        public int Conjure { get; internal set; }
        public ManaData Mana { get; } = new ManaData();
        #endregion

        #region Konstruktor
        internal ConjureData() { }
        #endregion
    }
}