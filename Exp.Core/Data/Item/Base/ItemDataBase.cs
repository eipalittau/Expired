namespace Exp.Data.Item {
    public abstract class ItemDataBase : DataBase {
        #region Properties / Felder
        public IItemTypeData ItemType { get; set; }
        public Enemy.IEnemyClassData? EnemyClass { get; set; }
        public bool AlwaysAvailable { get; set; }
        #endregion

        #region Konstruktor
        protected ItemDataBase(string aID, int aSortWeight, IItemTypeData aItemType, Exp.Data.Enemy.IEnemyClassData? aEnemyClass, bool aAlwaysAvailable)
            : base(aID, aSortWeight) {
            ItemType = aItemType;
            EnemyClass = aEnemyClass;
            AlwaysAvailable = aAlwaysAvailable;
        }
        #endregion

        #region Methoden
        protected static void AddInstance(IItemData aInstance) {
            Api.Item.Item.Singleton.Add(aInstance);
        }
        #endregion
    }
}