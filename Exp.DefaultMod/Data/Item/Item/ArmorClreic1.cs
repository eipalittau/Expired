using Exp.Data.Item.Item;

namespace Exp.DefaultMod.Item.Item {
    public sealed class ArmorClreic1 : ItemDataBase, IItemData {
        #region Konstruktor
        private ArmorClreic1()
            : base(nameof(ArmorClreic1), 2,
                  Api.Item.ItemType.Singleton.Get(nameof(DefaultMod.Item.ItemType.Armor)),
                  Api.Enemy.EnemyClass.Singleton.Get(nameof(Enemy.EnemyClass.Cleric)), false) {
            Name.Set(Util.LanguageEnum.Deutsch, "Stoffrüstung des überforderten Klerikers");
            Name.Set(Util.LanguageEnum.English, "");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new ArmorClreic1());
        }
        #endregion
    }
}