using Exp.Data.Item;

namespace Exp.DefaultMod.Item.Item {
    internal sealed class ArmorMage1 : ItemDataBase, IItemData {
        #region Konstruktor
        internal ArmorMage1()
            : base(nameof(ArmorMage1), 4,
                  Api.Item.ItemType.Singleton.Get(nameof(Item.ItemType.Armor)),
                  Api.Enemy.EnemyClass.Singleton.Get(nameof(Enemy.Mage)), false) {
            Name.Set(Util.LanguageEnum.Deutsch, "Stoffrüstung des gescheiterten Magiers");
            Name.Set(Util.LanguageEnum.English, "");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}