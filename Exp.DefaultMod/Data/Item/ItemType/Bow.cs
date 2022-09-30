using Exp.Data.Item.ItemType;
using Exp.Util.Enumeration;

namespace Exp.DefaultMod.Item.ItemType
{
    public sealed class Bow : ItemTypeDataBase, IItemTypeData {
        #region Konstruktor
        private Bow()
            : base(nameof(Bow), 500, 
                  Api.Player.Slot.Singleton.Get(nameof(Player.Slot.Mainhand)), 
                  Api.Player.Slot.Singleton.Get(nameof(Player.Slot.Offhand))) {
            Name.Set(LanguageEnum.Deutsch, "Bogen");
            Name.Set(LanguageEnum.English, "Bow");
            LoreDescription.Set(LanguageEnum.Deutsch, "");
            LoreDescription.Set(LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new Bow());
        }
        #endregion
    }
}