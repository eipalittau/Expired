using Exp.Data.Item.ItemType;
using Exp.Util.Enumeration;

namespace Exp.DefaultMod.Item.ItemType
{
    public sealed class Amulet : ItemTypeDataBase, IItemTypeData {
        #region Konstruktor
        private Amulet()
            : base(nameof(Amulet), 1400, 
                  Api.Player.Slot.Singleton.Get(nameof(Player.Slot.Neck))) {
            Name.Set(LanguageEnum.Deutsch, "Amulett");
            Name.Set(LanguageEnum.English, "Amulet");
            LoreDescription.Set(LanguageEnum.Deutsch, "");
            LoreDescription.Set(LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new Amulet());
        }
        #endregion
    }
}