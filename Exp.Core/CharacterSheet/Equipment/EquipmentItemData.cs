using Exp.Data.Item.Item;
using Exp.Data.Item.ItemQuality;
using Exp.Data.Player.Slot;
using System.ComponentModel;

namespace Exp.Core.Sheet {
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public sealed class EquipmentItemData: SheetBase {
        #region Properties / Felder
        public ISlotData Slot { get; init; }
        public IItemData? Item { get; set; }
        public IItemQualityData? ItemQuality { get; set; }
        #endregion

        #region Konstruktor
        internal EquipmentItemData(CharacterSheet aMain, ISlotData aSlot) 
            :base(aMain)
            => Slot = aSlot;
        #endregion
    }
}