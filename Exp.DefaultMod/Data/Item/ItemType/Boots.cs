using Exp.Data.Item.ItemType;
using Exp.Util.Enumeration;

namespace Exp.DefaultMod.Item.ItemType
{
    public sealed class Boots : ItemTypeDataBase, IItemTypeData {
        #region Konstruktor
        private Boots()
            : base(nameof(Boots), 200, 
                  Api.Player.Slot.Singleton.Get(nameof(Player.Slot.Feet))) {
            Name.Set(LanguageEnum.Deutsch, "Stiefel");
            Name.Set(LanguageEnum.English, "Boots");
            LoreDescription.Set(LanguageEnum.Deutsch, "");
            LoreDescription.Set(LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new Boots());
        }
        #endregion
    }
}