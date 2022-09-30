using Exp.Data.Item.ItemType;
using Exp.Util.Enumeration;

namespace Exp.DefaultMod.Item.ItemType
{
    public sealed class Headgear : ItemTypeDataBase, IItemTypeData {
        #region Konstruktor
        private Headgear()
            : base(nameof(Headgear), 1600, 
                  Api.Player.Slot.Singleton.Get(nameof(Player.Slot.Head))) {
            Name.Set(LanguageEnum.Deutsch, "Kopfbedeckung");
            Name.Set(LanguageEnum.English, "Headgear");
            LoreDescription.Set(LanguageEnum.Deutsch, "");
            LoreDescription.Set(LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new Headgear());
        }
        #endregion
    }
}