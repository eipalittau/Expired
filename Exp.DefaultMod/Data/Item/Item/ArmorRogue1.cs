using Exp.Data.Item.Item;

namespace Exp.DefaultMod.Item.Item {
    public sealed class ArmorRogue1 : ItemDataBase, IItemData {
        #region Konstruktor
        private ArmorRogue1()
            : base(nameof(ArmorRogue1), 3,
                  Api.Item.ItemType.Singleton.Get(nameof(DefaultMod.Item.ItemType.Armor)),
                  Api.Enemy.EnemyClass.Singleton.Get(nameof(Enemy.EnemyClass.Rogue)), false) {
            Name.Set(Util.LanguageEnum.Deutsch, "Stoffrüstung des erwischten Schurkens");
            Name.Set(Util.LanguageEnum.English, "");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new ArmorRogue1());
        }
        #endregion
    }
}