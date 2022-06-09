using Exp.Data.General.DamageType;
using System.ComponentModel;

namespace Exp.Core.Sheet {
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public sealed class DamageItemData : SheetBase {
        #region Properties / Felder
        public IDamageTypeData DamageType { get; init; }
        #endregion

        #region Konstruktor
        internal DamageItemData(CharacterSheet aMain, IDamageTypeData aDamageType)
            : base(aMain) {
            DamageType = aDamageType;
        }
        #endregion
    }
}