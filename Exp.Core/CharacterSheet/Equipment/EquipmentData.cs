using Exp.Data.Item.Item;
using Exp.Data.Item.ItemQuality;
using Exp.Data.Player.Slot;

namespace Exp.Api.Player.Sheet {
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class EquipmentData {
        #region Properties / Felder
        public ISlotData Slot { get; init; }
        public IItemData? Item { get; set; }
        public IItemQualityData? ItemQuality { get; set; }
        #endregion

        #region Konstruktor
        internal EquipmentData(ISlotData aSlot) {
            Slot = aSlot;
        }
        #endregion
    }
}