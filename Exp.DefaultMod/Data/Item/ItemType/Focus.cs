using Exp.Data.Item.ItemType;
using Exp.Util.Enumeration;

namespace Exp.DefaultMod.Item.ItemType
{
    public sealed class Focus : ItemTypeDataBase, IItemTypeData {
        #region Konstruktor
        private Focus()
            : base(nameof(Focus), 1100, 
                  Api.Player.Slot.Singleton.Get(nameof(Player.Slot.Offhand))) {
            Name.Set(LanguageEnum.Deutsch, "Heiliges Symbol");
            Name.Set(LanguageEnum.English, "Focus");
            LoreDescription.Set(LanguageEnum.Deutsch, "");
            LoreDescription.Set(LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new Focus());
        }
        #endregion
    }
}