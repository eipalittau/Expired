using Exp.Data.Item.ItemType;
using Exp.Util.Enumeration;

namespace Exp.DefaultMod.Item.ItemType
{
    public sealed class Consumable : ItemTypeDataBase, IItemTypeData {
        #region Konstruktor
        private Consumable()
            : base(nameof(Consumable), 1800, 
                  Api.Player.Slot.Singleton.Get(nameof(Player.Slot.Bag))) {
            Name.Set(LanguageEnum.Deutsch, "Konsumierbar");
            Name.Set(LanguageEnum.English, "Consumable");
            LoreDescription.Set(LanguageEnum.Deutsch, "");
            LoreDescription.Set(LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new Consumable());
        }
        #endregion
    }
}