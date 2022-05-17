using Exp.Data.Item.ItemType;

namespace Exp.DefaultMod.Item.ItemType {
    public sealed class Headgear : ItemTypeDataBase, IItemTypeData {
        #region Konstruktor
        private Headgear()
            : base(nameof(Headgear), 1600, 
                  Api.Player.Slot.Singleton.Get(nameof(Player.Slot.Head))) {
            Name.Set(Util.LanguageEnum.Deutsch, "Kopfbedeckung");
            Name.Set(Util.LanguageEnum.English, "Headgear");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new Headgear());
        }
        #endregion
    }
}