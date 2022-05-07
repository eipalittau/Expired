namespace Exp.Api.Player.Sheet {
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class EquipmentData {
        #region Properties / Felder
        public Data.Player.ISlotData Slot { get; init; }
        public Data.Item.IItemData? Item { get; set; }
        public Data.Item.IItemQualityData? ItemQuality { get; set; }
        #endregion

        #region Konstruktor
        internal EquipmentData(Data.Player.ISlotData aSlot) {
            Slot = aSlot;
        }
        #endregion
    }
}