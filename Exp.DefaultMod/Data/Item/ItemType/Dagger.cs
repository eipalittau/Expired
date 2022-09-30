using Exp.Data.Item.ItemType;
using Exp.Util.Enumeration;

namespace Exp.DefaultMod.Item.ItemType
{
    public sealed class Dagger : ItemTypeDataBase, IItemTypeData {
        #region Konstruktor
        private Dagger()
            : base(nameof(Dagger), 900, 
                  Api.Player.Slot.Singleton.Get(nameof(Player.Slot.Offhand))) {
            Name.Set(LanguageEnum.Deutsch, "Dolch");
            Name.Set(LanguageEnum.English, "Dagger");
            LoreDescription.Set(LanguageEnum.Deutsch, "");
            LoreDescription.Set(LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new Dagger());
        }
        #endregion
    }
}