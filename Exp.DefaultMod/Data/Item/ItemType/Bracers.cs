namespace Exp.DefaultMod.Item.ItemType {
    public sealed class Bracers : Exp.Data.Item.ItemTypeDataBase, Exp.Data.Item.IItemTypeData {
        #region Konstruktor
        private Bracers()
            : base(nameof(Bracers), 1700, null, 
                  Api.Player.Slot.Singleton.Get(nameof(Player.Slot.WristLeft)), 
                  Api.Player.Slot.Singleton.Get(nameof(Player.Slot.WristRight))) {
            Name.Set(Util.LanguageEnum.Deutsch, "Armschutz");
            Name.Set(Util.LanguageEnum.English, "Bracers");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new Bracers());
        }
        #endregion
    }
}