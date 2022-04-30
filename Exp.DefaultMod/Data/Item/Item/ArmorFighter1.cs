using Exp.Data.Item;

namespace Exp.DefaultMod.Item.ItemQuality {
    internal sealed class ArmorFighter1 : ItemDataBase, IItemData {
        #region Konstruktor
        internal ArmorFighter1()
            : base(nameof(ArmorFighter1), 1, 
                  Api.Item.ItemType.Singleton.Get(nameof(Item.ItemType.Armor)), 
                  Api.Enemy.EnemyClass.Singleton.Get(nameof(Enemy.Fighter)), false) {
            Name.Set(Util.LanguageEnum.Deutsch, "Stoffrüstung des besiegten Kämpfers");
            Name.Set(Util.LanguageEnum.English, "");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}