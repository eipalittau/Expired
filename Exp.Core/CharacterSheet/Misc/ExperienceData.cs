namespace Exp.Api.Player.Sheet {
    public sealed class ExperienceData : SheetBase {
        #region Properties / Felder
        #endregion

        #region Konstruktor
        internal ExperienceData(CharacterSheet aMain)
            : base(aMain) { }
        #endregion

        #region Methoden
        internal void LevelUp() {
            base.OnDecrease(base.Max);
        }
        #endregion
    }
}