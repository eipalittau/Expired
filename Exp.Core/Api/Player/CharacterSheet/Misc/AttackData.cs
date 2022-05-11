namespace Exp.Api.Player.Sheet {
    public sealed class AttackData : SheetBase {
        #region Properties / Felder
        public Data.General.IDamageTypeData DamageType { get; init; } 
        #endregion

        #region Konstruktor
        internal AttackData(CharacterSheet aMain, Data.General.IDamageTypeData aDamageType)
            : base(aMain) {
            DamageType = aDamageType;
        }
        #endregion

        #region Methoden
        #endregion
    }
}