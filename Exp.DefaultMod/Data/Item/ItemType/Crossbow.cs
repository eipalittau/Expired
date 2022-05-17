using Exp.Data.Item.ItemType;

namespace Exp.DefaultMod.Item.ItemType {
    public sealed class Crossbow : ItemTypeDataBase, IItemTypeData {
        #region Konstruktor
        private Crossbow()
            : base(nameof(Crossbow), 600, 
                  Api.Player.Slot.Singleton.Get(nameof(Player.Slot.Mainhand)), 
                  Api.Player.Slot.Singleton.Get(nameof(Player.Slot.Offhand))) {
            Name.Set(Util.LanguageEnum.Deutsch, "Armbrust");
            Name.Set(Util.LanguageEnum.English, "Crossbow");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new Crossbow());
        }
        #endregion
    }
}