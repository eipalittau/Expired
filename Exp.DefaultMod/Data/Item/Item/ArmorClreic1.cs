using Exp.Data.Item.Item;
using Exp.Util.Enumeration;

namespace Exp.DefaultMod.Item.Item
{
    public sealed class ArmorClreic1 : ItemDataBase, IItemData {
        #region Konstruktor
        private ArmorClreic1()
            : base(nameof(ArmorClreic1), 2,
                  Api.Item.ItemType.Singleton.Get(nameof(DefaultMod.Item.ItemType.Armor)),
                  Api.Enemy.EnemyClass.Singleton.Get(nameof(Enemy.EnemyClass.Cleric)), false) {
            Name.Set(LanguageEnum.Deutsch, "Stoffrüstung des überforderten Klerikers");
            Name.Set(LanguageEnum.English, "");
            LoreDescription.Set(LanguageEnum.Deutsch, "");
            LoreDescription.Set(LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new ArmorClreic1());
        }
        #endregion
    }
}