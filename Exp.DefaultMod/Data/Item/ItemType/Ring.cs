namespace Exp.DefaultMod.Item.ItemType {
    public sealed class Ring : Exp.Data.Item.ItemTypeDataBase, Exp.Data.Item.IItemTypeData {
        #region Konstruktor
        private Ring()
            : base(nameof(Ring), 1300, null, 
                  Api.Player.Slot.Singleton.Get(nameof(Player.Slot.RingFingerLeft)), 
                  Api.Player.Slot.Singleton.Get(nameof(Player.Slot.RingFingerRight))) {
            Name.Set(Util.LanguageEnum.Deutsch, "Ring");
            Name.Set(Util.LanguageEnum.English, "Ring");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new Ring());
        }
        #endregion
    }
}