using Exp.Data.Item.ItemType;

namespace Exp.DefaultMod.Item.ItemType {
    public sealed class Focus : ItemTypeDataBase, IItemTypeData {
        #region Konstruktor
        private Focus()
            : base(nameof(Focus), 1100, 
                  Api.Player.Slot.Singleton.Get(nameof(Player.Slot.Offhand))) {
            Name.Set(Util.LanguageEnum.Deutsch, "Heiliges Symbol");
            Name.Set(Util.LanguageEnum.English, "Focus");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new Focus());
        }
        #endregion
    }
}