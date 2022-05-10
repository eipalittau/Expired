namespace Exp.Api.Player.Sheet {
    public sealed class DamageData : SheetBase {
        #region Properties / Felder
        public Data.General.IDamageTypeData DamageType { get; init; }
        #endregion

        #region Konstruktor
        internal DamageData(CharacterSheet aMain, Data.General.IDamageTypeData aDamageType)
            : base(aMain) {
            DamageType = aDamageType;
        }
        #endregion

        #region Methoden
        #endregion
    }
}