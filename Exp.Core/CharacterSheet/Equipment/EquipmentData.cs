using Exp.Data.Player.Slot;
using System.ComponentModel;

namespace Exp.Core.Sheet {
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public sealed class EquipmentData : DataListBase<EquipmentItemData> {
        #region Konstruktor
        internal EquipmentData(CharacterSheet aMain)
            : base() {
            Api.Player.Slot.Singleton.Enumerate(true).ToList()
                .ForEach(x => base.Add(new EquipmentItemData(aMain, x)));
        }
        #endregion

        #region Methoden
        internal EquipmentItemData Get(ISlotData aSlot) {
            return base.Get(x => x.Slot == aSlot);
        }
        #endregion
    }
}