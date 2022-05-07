namespace Exp.DefaultMod.Item.Item {
    public sealed class ArmorMage1 : Exp.Data.Item.ItemDataBase, Exp.Data.Item.IItemData {
        #region Konstruktor
        private ArmorMage1()
            : base(nameof(ArmorMage1), 4,
                  Api.Item.ItemType.Singleton.Get(nameof(DefaultMod.Item.ItemType.Armor)),
                  Api.Enemy.EnemyClass.Singleton.Get(nameof(Enemy.EnemyClass.Mage)), false) {
            Name.Set(Util.LanguageEnum.Deutsch, "Stoffrüstung des gescheiterten Magiers");
            Name.Set(Util.LanguageEnum.English, "");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new ArmorMage1());
        }
        #endregion
    }
}