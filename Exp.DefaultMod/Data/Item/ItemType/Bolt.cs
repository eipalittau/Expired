namespace Exp.DefaultMod.Item.ItemType {
    public sealed class Bolt : Exp.Data.Item.ItemTypeDataBase, Exp.Data.Item.IItemTypeData {
        #region Konstruktor
        private Bolt()
            : base(nameof(Bolt), 800, 
                  Api.Item.ItemType.Singleton.Get(nameof(Crossbow)), 
                  Api.Player.Slot.Singleton.Get(nameof(Player.Slot.Mainhand)), 
                  Api.Player.Slot.Singleton.Get(nameof(Player.Slot.Offhand))) {
            Name.Set(Util.LanguageEnum.Deutsch, "Bolzen");
            Name.Set(Util.LanguageEnum.English, "Bolt");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new Bolt());
        }
        #endregion
    }
}