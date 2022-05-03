using Exp.Data.Item;

namespace Exp.DefaultMod.Item.Item {
    internal sealed class ArmorClreic1 : ItemDataBase, IItemData {
        #region Konstruktor
        internal ArmorClreic1()
            : base(nameof(ArmorClreic1), 2,
                  Api.Item.ItemType.Singleton.Get(nameof(Item.ItemType.Armor)),
                  Api.Enemy.EnemyClass.Singleton.Get(nameof(Enemy.Cleric)), false) {
            Name.Set(Util.LanguageEnum.Deutsch, "Stoffrüstung des überforderten Klerikers");
            Name.Set(Util.LanguageEnum.English, "");
            LoreDescription.Set(Util.LanguageEnum.Deutsch, "");
            LoreDescription.Set(Util.LanguageEnum.English, "");
        }
        #endregion
    }
}