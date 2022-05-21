namespace Exp.Core.Sheet {
    public sealed class ExperienceData : SheetBase {
        #region Properties / Felder
        #endregion

        #region Konstruktor
        internal ExperienceData(CharacterSheet aMain)
            : base(aMain, true) { }
        #endregion

        #region Methoden
        internal void LevelUp() {
            base.OnDecrease(base.Max);
        }

        internal void Add(int aPoints) {
            OnIncrease(aPoints, true);
        }
        #endregion
    }
}