using Exp.Data.Item;

namespace Exp.DefaultMod.Item.ItemQuality {
    internal abstract class ItemDataBase : DataBase, IItemDataBase {
        #region Properties / Felder
        public IItemTypeData ItemType { get; set; }
        public Data.Enemy.IEnemyClassData? EnemyClass { get; set; }
        public bool AlwaysAvailable { get; set; }

        #endregion

        #region Konstruktor
        private protected ItemDataBase(string aID, int aSortWeight, IItemTypeData aItemType, Data.Enemy.IEnemyClassData? aEnemyClass, bool aAlwaysAvailable)
            : base(aID, aSortWeight) {
            ItemType = aItemType;
            EnemyClass=aEnemyClass;
            AlwaysAvailable = aAlwaysAvailable;
        }
        #endregion
    }
}