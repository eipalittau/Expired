namespace Exp.DefaultMod.Item.ItemType {
    public sealed class Cape : Exp.Data.Item.ItemTypeDataBase, Exp.Data.Item.IItemTypeData {
        #region Konstruktor
        private Cape()
            : base(nameof(Cape), 1500, null, 
                  Api.Player.Slot.Singleton.Get(nameof(Player.Slot.Shoulders))) {
            Name.Set(Util.LanguageEnum.Deutsch, "Umhang");
            Name.Set(Util.LanguageEnum.English, "Cape");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new Cape());
        }
        #endregion
    }
}