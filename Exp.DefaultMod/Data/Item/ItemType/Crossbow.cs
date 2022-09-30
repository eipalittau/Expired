using Exp.Data.Item.ItemType;
using Exp.Util.Enumeration;

namespace Exp.DefaultMod.Item.ItemType
{
    public sealed class Crossbow : ItemTypeDataBase, IItemTypeData {
        #region Konstruktor
        private Crossbow()
            : base(nameof(Crossbow), 600, 
                  Api.Player.Slot.Singleton.Get(nameof(Player.Slot.Mainhand)), 
                  Api.Player.Slot.Singleton.Get(nameof(Player.Slot.Offhand))) {
            Name.Set(LanguageEnum.Deutsch, "Armbrust");
            Name.Set(LanguageEnum.English, "Crossbow");
            LoreDescription.Set(LanguageEnum.Deutsch, "");
            LoreDescription.Set(LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new Crossbow());
        }
        #endregion
    }
}