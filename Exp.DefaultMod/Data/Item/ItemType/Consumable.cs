namespace Exp.DefaultMod.Item.ItemType {
    public sealed class Consumable : Exp.Data.Item.ItemTypeDataBase, Exp.Data.Item.IItemTypeData {
        #region Konstruktor
        private Consumable()
            : base(nameof(Consumable), 1800, null, 
                  Api.Player.Slot.Singleton.Get(nameof(Player.Slot.Bag))) {
            Name.Set(Util.LanguageEnum.Deutsch, "Konsumierbar");
            Name.Set(Util.LanguageEnum.English, "Consumable");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new Consumable());
        }
        #endregion
    }
}