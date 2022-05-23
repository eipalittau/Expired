using Exp.Api.General;

namespace Exp.Core.Sheet {
    public sealed class SneakyData : SheetBase {
        #region Properties / Felder
        #endregion

        #region Konstruktor
        internal SneakyData(CharacterSheet aMain)
            : base(aMain) { }
        #endregion

        #region Methoden
        internal void LevelUp() {
            base.LevelUp(TargetEffectEnum.Sneaky);
        }
        #endregion
    }
}