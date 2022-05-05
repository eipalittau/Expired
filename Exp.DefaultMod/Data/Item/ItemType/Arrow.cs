namespace Exp.DefaultMod.Item.ItemType {
    public sealed class Arrow : Exp.Data.Item.ItemTypeDataBase, Exp.Data.Item.IItemTypeData {
        #region Konstruktor
        private Arrow()
            : base(nameof(Arrow), 700, 
                  Api.Item.ItemType.Singleton.Get(nameof(Bow)),
                  Api.Player.Slot.Singleton.Get(nameof(Player.Slot.Mainhand)),
                  Api.Player.Slot.Singleton.Get(nameof(Player.Slot.Offhand))) {
            Name.Set(Util.LanguageEnum.Deutsch, "Pfeile");
            Name.Set(Util.LanguageEnum.English, "Arrows");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new Arrow());
        }
        #endregion
    }
}