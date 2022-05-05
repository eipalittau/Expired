namespace Exp.DefaultMod.Item.ItemType {
    public sealed class Shield : Exp.Data.Item.ItemTypeDataBase, Exp.Data.Item.IItemTypeData {
        #region Konstruktor
        private Shield()
            : base(nameof(Shield), 1000, null, 
                  Api.Player.Slot.Singleton.Get(nameof(Player.Slot.Offhand))) {
            Name.Set(Util.LanguageEnum.Deutsch, "Schild");
            Name.Set(Util.LanguageEnum.English, "Shield");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new Shield());
        }
        #endregion
    }
}