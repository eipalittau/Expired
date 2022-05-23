using Exp.Api.General;

namespace Exp.Core.Sheet {
    public sealed class MovementData : SheetBase {
        #region Properties / Felder
        #endregion

        #region Konstruktor
        internal MovementData(CharacterSheet aMain)
            : base(aMain) { }
        #endregion

        #region Methoden
        internal void LevelUp() {
            base.LevelUp(TargetEffectEnum.Movement);
        }
        #endregion
    }
}