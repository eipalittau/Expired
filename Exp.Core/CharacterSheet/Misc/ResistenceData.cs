using Exp.Api.General;

namespace Exp.Core.Sheet {
    public sealed class ResistenceData : SheetBase {
        #region Properties / Felder
        #endregion

        #region Konstruktor
        internal ResistenceData(CharacterSheet aMain)
            : base(aMain) { }
        #endregion

        #region Methoden
        internal void LevelUp() {
            base.LevelUp(TargetEffectEnum.Resistence);
        }
        #endregion
    }
}