using Exp.Data.Item.ItemType;
using Exp.Util.Enumeration;

namespace Exp.DefaultMod.Item.ItemType
{
    public sealed class Cape : ItemTypeDataBase, IItemTypeData {
        #region Konstruktor
        private Cape()
            : base(nameof(Cape), 1500, 
                  Api.Player.Slot.Singleton.Get(nameof(Player.Slot.Shoulders))) {
            Name.Set(LanguageEnum.Deutsch, "Umhang");
            Name.Set(LanguageEnum.English, "Cape");
            LoreDescription.Set(LanguageEnum.Deutsch, "");
            LoreDescription.Set(LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new Cape());
        }
        #endregion
    }
}