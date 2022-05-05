namespace Exp.DefaultMod.Item.ItemType {
    public sealed class Grimoire : Exp.Data.Item.ItemTypeDataBase, Exp.Data.Item.IItemTypeData {
        #region Konstruktor
        private Grimoire()
            : base(nameof(Grimoire), 1200, null, 
                  Api.Player.Slot.Singleton.Get(nameof(Player.Slot.Offhand))) {
            Name.Set(Util.LanguageEnum.Deutsch, "Zauberbuch");
            Name.Set(Util.LanguageEnum.English, "Grimoire");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new Grimoire());
        }
        #endregion
    }
}