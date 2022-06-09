using Exp.Api.General;
using System.ComponentModel;

namespace Exp.Core.Sheet {
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
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