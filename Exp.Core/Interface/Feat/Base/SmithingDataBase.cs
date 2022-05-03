namespace Exp.Data.Feat {
    public abstract class SmithingDataBase : FeatDataBase<ISmithingData> {
        #region Properties / Felder
        public List<Item.IItemTypeData> ItemTypeList { get; init; } 
        #endregion

        #region Konstruktor
        protected SmithingDataBase(string aID, int aSortWeight, General.ITierData aTier, params Item.IItemTypeData[] aItemTypes)
            : base(aID, aSortWeight, aTier) {
            if (aItemTypes == null || aItemTypes.Length == 0) {
                ItemTypeList = new();
            } else {
                ItemTypeList = aItemTypes.ToList();
            }
        }

        protected SmithingDataBase(string aID, int aSortWeight, General.ITierData aTier, ISmithingData aPrerequisite, params Item.IItemTypeData[] aItemTypes)
            : base(aID, aSortWeight, aTier, aPrerequisite) {
            if (aItemTypes == null || aItemTypes.Length == 0) {
                ItemTypeList = new();
            } else {
                ItemTypeList = aItemTypes.ToList();
            }
        }
        #endregion
    }
}