using Exp.Data.Item.ItemType;
using Exp.Util.Enumeration;

namespace Exp.DefaultMod.Item.ItemType
{
    public sealed class Armor : ItemTypeDataBase, IItemTypeData {
        #region Konstruktor
        private Armor()
            : base(nameof(Armor), 100, Api.Player.Slot.Singleton.Get(nameof(Player.Slot.Body))) {
            Name.Set(LanguageEnum.Deutsch, "Rüstung");
            Name.Set(LanguageEnum.English, "Armor");
            LoreDescription.Set(LanguageEnum.Deutsch, "");
            LoreDescription.Set(LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new Armor());
        }
        #endregion
    }
}