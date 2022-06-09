using System.ComponentModel;

namespace Exp.Core.Sheet {
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public sealed class ConjureData {
        #region Properties / Felder
        public int CasterLevel { get; internal set; }
        public ManaData Mana { get; init; }
        #endregion

        #region Konstruktor
        internal ConjureData(CharacterSheet aMain)
            => Mana = new ManaData(aMain);
        #endregion

        #region Methoden
        internal void LevelUp() {
            Mana.LevelUp();
        }

        internal void OnNewDay() {
            Mana.OnNewDay();
        }
        #endregion
    }
}