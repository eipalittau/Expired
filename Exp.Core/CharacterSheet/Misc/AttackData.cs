using Exp.Data.General.DamageType;

namespace Exp.Api.Player.Sheet {
    public sealed class AttackData : SheetBase {
        #region Properties / Felder
        public IDamageTypeData DamageType { get; init; } 
        #endregion

        #region Konstruktor
        internal AttackData(CharacterSheet aMain, IDamageTypeData aDamageType)
            : base(aMain) {
            DamageType = aDamageType;
        }
        #endregion

        #region Methoden
        #endregion
    }
}