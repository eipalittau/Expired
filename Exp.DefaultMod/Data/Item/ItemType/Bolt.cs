using Exp.Data.Item.ItemType;
using Exp.Util.Enumeration;

namespace Exp.DefaultMod.Item.ItemType
{
    public sealed class Bolt : ItemTypeDataBase, IItemTypeData {
        #region Konstruktor
        private Bolt()
            : base(nameof(Bolt), 800, 
                  Api.Item.ItemType.Singleton.Get(nameof(Crossbow)), 
                  Api.Player.Slot.Singleton.Get(nameof(Player.Slot.Mainhand)), 
                  Api.Player.Slot.Singleton.Get(nameof(Player.Slot.Offhand))) {
            Name.Set(LanguageEnum.Deutsch, "Bolzen");
            Name.Set(LanguageEnum.English, "Bolt");
            LoreDescription.Set(LanguageEnum.Deutsch, "");
            LoreDescription.Set(LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new Bolt());
        }
        #endregion
    }
}