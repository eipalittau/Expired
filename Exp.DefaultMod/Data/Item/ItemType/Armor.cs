namespace Exp.DefaultMod.Item.ItemType {
    internal sealed class Armor : Exp.Data.Item.ItemTypeDataBase, Exp.Data.Item.IItemTypeData {
        #region Konstruktor
        internal Armor()
            : base(nameof(Armor), 100, null, 
                  Api.Player.Slot.Singleton.Get(nameof(Player.Slot.Body))) {
            Name.Set(Util.LanguageEnum.Deutsch, "Rüstung");
            Name.Set(Util.LanguageEnum.English, "Armor");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}