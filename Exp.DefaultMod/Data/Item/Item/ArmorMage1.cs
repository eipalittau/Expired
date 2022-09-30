using Exp.Data.Item.Item;
using Exp.Util.Enumeration;

namespace Exp.DefaultMod.Item.Item
{
    public sealed class ArmorMage1 : ItemDataBase, IItemData {
        #region Konstruktor
        private ArmorMage1()
            : base(nameof(ArmorMage1), 4,
                  Api.Item.ItemType.Singleton.Get(nameof(DefaultMod.Item.ItemType.Armor)),
                  Api.Enemy.EnemyClass.Singleton.Get(nameof(Enemy.EnemyClass.Mage)), false) {
            Name.Set(LanguageEnum.Deutsch, "Stoffrüstung des gescheiterten Magiers");
            Name.Set(LanguageEnum.English, "");
            LoreDescription.Set(LanguageEnum.Deutsch, "");
            LoreDescription.Set(LanguageEnum.English, "");
        }
        #endregion

        #region Methoden
        public static void Add() {
            AddInstance(new ArmorMage1());
        }
        #endregion
    }
}