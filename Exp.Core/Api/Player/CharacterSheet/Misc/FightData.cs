namespace Exp.Api.Player.Sheet {
    public sealed class FightData {
        #region Properties / Felder
        public ArmorClassData ArmorClass { get; init; }
        public int Resistence { get; set; }
        public int Attack { get; internal set; }
        public bool Damage { get; private set; }
        public bool Sneaky { get; set; }
        #endregion

        #region Konstruktor
        internal FightData(CharacterSheet aMain) 
            => ArmorClass = new ArmorClassData(aMain);
        #endregion

        #region Methoden
        #endregion
    }
}