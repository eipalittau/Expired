using Exp.Data.General.DamageType;
using System.ComponentModel;

namespace Exp.Core.Sheet {
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public sealed class AttackItemData : SheetBase {
        #region Properties / Felder
        public IDamageTypeData DamageType { get; init; }
        #endregion

        #region Konstruktor
        internal AttackItemData(CharacterSheet aMain, IDamageTypeData aDamageType)
            : base(aMain)
            => DamageType = aDamageType;
        #endregion
    }
}