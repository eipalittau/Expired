using Exp.Data.Item.ItemType;
using Exp.Util.Enumeration;

namespace Exp.DefaultMod.Item.ItemType
{
    public sealed class Ring : ItemTypeDataBase, IItemTypeData {
        #region Konstruktor
        private Ring()
            : base(nameof(Ring), 1300, 
                  Api.Player.Slot.Singleton.Get(nameof(Player.Slot.RingFingerLeft)), 
                  Api.Player.Slot.Singleton.Get(nameof(Player.Slot.RingFingerRight))) {
            Name.Set(LanguageEnum.Deutsch, "Ring");
            Name.Set(LanguageEnum.English, "Ring");
            LoreDescription.Set(LanguageEnum.Deutsch, "");
            LoreDescription.Set(LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new Ring());
        }
        #endregion
    }
}