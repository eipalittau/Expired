namespace Exp.DefaultMod.Item.ItemType {
    public sealed class Amulet : Exp.Data.Item.ItemTypeDataBase, Exp.Data.Item.IItemTypeData {
        #region Konstruktor
        private Amulet()
            : base(nameof(Amulet), 1400, null, 
                  Api.Player.Slot.Singleton.Get(nameof(Player.Slot.Neck))) {
            Name.Set(Util.LanguageEnum.Deutsch, "Amulett");
            Name.Set(Util.LanguageEnum.English, "Amulet");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new Amulet());
        }
        #endregion
    }
}