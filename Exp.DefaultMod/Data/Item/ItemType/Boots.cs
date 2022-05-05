namespace Exp.DefaultMod.Item.ItemType {
    public sealed class Boots : Exp.Data.Item.ItemTypeDataBase, Exp.Data.Item.IItemTypeData {
        #region Konstruktor
        private Boots()
            : base(nameof(Boots), 200, null, 
                  Api.Player.Slot.Singleton.Get(nameof(Player.Slot.Feet))) {
            Name.Set(Util.LanguageEnum.Deutsch, "Stiefel");
            Name.Set(Util.LanguageEnum.English, "Boots");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new Boots());
        }
        #endregion
    }
}