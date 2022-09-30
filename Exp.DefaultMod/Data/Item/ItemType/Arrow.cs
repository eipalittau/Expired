using Exp.Data.Item.ItemType;
using Exp.Util.Enumeration;

namespace Exp.DefaultMod.Item.ItemType
{
    public sealed class Arrow : ItemTypeDataBase, IItemTypeData {
        #region Konstruktor
        private Arrow()
            : base(nameof(Arrow), 700, 
                  Api.Item.ItemType.Singleton.Get(nameof(Bow)),
                  Api.Player.Slot.Singleton.Get(nameof(Player.Slot.Mainhand)),
                  Api.Player.Slot.Singleton.Get(nameof(Player.Slot.Offhand))) {
            Name.Set(LanguageEnum.Deutsch, "Pfeile");
            Name.Set(LanguageEnum.English, "Arrows");
            LoreDescription.Set(LanguageEnum.Deutsch, "");
            LoreDescription.Set(LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new Arrow());
        }
        #endregion
    }
}