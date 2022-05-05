namespace Exp.DefaultMod.Item.Item {
    public sealed class ArmorFighter1 : Exp.Data.Item.ItemDataBase, Exp.Data.Item.IItemData {
        #region Konstruktor
        private ArmorFighter1()
            : base(nameof(ArmorFighter1), 1, 
                  Api.Item.ItemType.Singleton.Get(nameof(DefaultMod.Item.ItemType.Armor)), 
                  Api.Enemy.EnemyClass.Singleton.Get(nameof(Enemy.EnemyClass.Fighter)), false) {
            Name.Set(Util.LanguageEnum.Deutsch, "Stoffrüstung des besiegten Kämpfers");
            Name.Set(Util.LanguageEnum.English, "");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new ArmorFighter1());
        }
        #endregion
    }
}