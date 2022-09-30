using Exp.Data.Item.ItemType;
using Exp.Util.Enumeration;

namespace Exp.DefaultMod.Item.ItemType
{
    public sealed class Shield : ItemTypeDataBase, IItemTypeData {
        #region Konstruktor
        private Shield()
            : base(nameof(Shield), 1000, 
                  Api.Player.Slot.Singleton.Get(nameof(Player.Slot.Offhand))) {
            Name.Set(LanguageEnum.Deutsch, "Schild");
            Name.Set(LanguageEnum.English, "Shield");
            LoreDescription.Set(LanguageEnum.Deutsch, "");
            LoreDescription.Set(LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new Shield());
        }
        #endregion
    }
}