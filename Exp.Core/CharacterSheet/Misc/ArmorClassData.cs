using Exp.Api.General;

namespace Exp.Core.Sheet {
    public sealed class ArmorClassData : SheetBase {
        #region Properties / Felder

        public int Natural { get; set; }
        #endregion

        #region Konstruktor
        internal ArmorClassData(CharacterSheet aMain)
            : base(aMain) {
            if (Api.Player.LevelUp.Singleton.Contains(TargetEffectEnum.NaturalArmor)) {
                Natural = Api.Player.LevelUp.Singleton.Get(TargetEffectEnum.NaturalArmor).Base.Value;
            }
        }
        #endregion

        #region Methoden
        internal void LevelUp() {
            base.LevelUp(TargetEffectEnum.Armor);
        }
        #endregion
    }
}