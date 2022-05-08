namespace Exp.Api.Player.Sheet {
    public sealed class FightData {
        #region Properties / Felder
        public int ArmorClass { get; set; }
        public int Resistence { get; set; }
        public int Attack { get; internal set; }
        public bool Damage { get; private set; }
        public bool Sneaky { get; set; }
        #endregion

        #region Konstruktor
        internal FightData(CharacterSheet aMain) { }
        #endregion

        #region Methoden
        #endregion
    }
}