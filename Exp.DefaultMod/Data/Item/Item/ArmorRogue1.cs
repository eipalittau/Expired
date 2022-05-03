using Exp.Data.Item;

namespace Exp.DefaultMod.Item.Item {
    internal sealed class ArmorRogue1 : ItemDataBase, IItemData {
        #region Konstruktor
        internal ArmorRogue1()
            : base(nameof(ArmorRogue1), 3,
                  Api.Item.ItemType.Singleton.Get(nameof(Item.ItemType.Armor)),
                  Api.Enemy.EnemyClass.Singleton.Get(nameof(Enemy.Rogue)), false) {
            Name.Set(Util.LanguageEnum.Deutsch, "Stoffrüstung des erwischten Schurkens");
            Name.Set(Util.LanguageEnum.English, "");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}