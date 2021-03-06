using Exp.Data.Item.ItemType;

namespace Exp.DefaultMod.Item.ItemType {
    public sealed class Dagger : ItemTypeDataBase, IItemTypeData {
        #region Konstruktor
        private Dagger()
            : base(nameof(Dagger), 900, 
                  Api.Player.Slot.Singleton.Get(nameof(Player.Slot.Offhand))) {
            Name.Set(Util.LanguageEnum.Deutsch, "Dolch");
            Name.Set(Util.LanguageEnum.English, "Dagger");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new Dagger());
        }
        #endregion
    }
}