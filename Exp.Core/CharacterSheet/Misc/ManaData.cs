using Exp.Api.General;

namespace Exp.Core.Sheet {
    public sealed class ManaData : SheetBase {
        #region Properties / Felder
        #endregion

        #region Konstruktor
        internal ManaData(CharacterSheet aMain) 
            : base(aMain) { }
        #endregion

        #region Methoden
        internal void LevelUp() {
            base.LevelUp(TargetEffectEnum.Mana);
        }

        public void OnConjure(int aPoints) {
            base.OnDecrease(aPoints);
        }

        public void OnRestore(int aPoints) {
            base.OnIncrease(aPoints);
        }
        #endregion
    }
}