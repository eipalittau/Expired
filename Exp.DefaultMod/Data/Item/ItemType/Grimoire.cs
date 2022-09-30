using Exp.Data.Item.ItemType;
using Exp.Util.Enumeration;

namespace Exp.DefaultMod.Item.ItemType
{
    public sealed class Grimoire : ItemTypeDataBase, IItemTypeData {
        #region Konstruktor
        private Grimoire()
            : base(nameof(Grimoire), 1200, 
                  Api.Player.Slot.Singleton.Get(nameof(Player.Slot.Offhand))) {
            Name.Set(LanguageEnum.Deutsch, "Zauberbuch");
            Name.Set(LanguageEnum.English, "Grimoire");
            LoreDescription.Set(LanguageEnum.Deutsch, "");
            LoreDescription.Set(LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new Grimoire());
        }
        #endregion
    }
}