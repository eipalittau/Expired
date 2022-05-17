using Exp.Data.Item.ItemType;

namespace Exp.DefaultMod.Item.ItemType {
    public sealed class Armor : ItemTypeDataBase, IItemTypeData {
        #region Konstruktor
        private Armor()
            : base(nameof(Armor), 100, Api.Player.Slot.Singleton.Get(nameof(Player.Slot.Body))) {
            Name.Set(Util.LanguageEnum.Deutsch, "Rüstung");
            Name.Set(Util.LanguageEnum.English, "Armor");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new Armor());
        }
        #endregion
    }
}