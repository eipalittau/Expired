using Exp.Data.Equipment;
using Exp.Extension;

namespace Exp.DefaultMod.Feat {
    public abstract class SmithingDataBase : DataBase, Exp.Data.Feat.ISmithingDataBase {
        #region Properties / Felder
        public Exp.Data.General.ITierData Tier { get; set; }
        public Exp.Data.Feat.ISmithingData? Prerequisite { get; init; }
        public List<IItemTypeData> ItemTypeList { get; init; } 
        public Util.LanguageBasedData EffektDescription { get; } = new Util.LanguageBasedData();
        #endregion

        #region Konstruktor
        private protected SmithingDataBase(string aID, int aSortWeight, Exp.Data.General.ITierData aTier, Exp.Data.Feat.ISmithingData? aPrerequisite, params IItemTypeData[] aItemTypes)
            : base(aID, aSortWeight) {
            Tier = aTier;
            Prerequisite = aPrerequisite;
            if (aItemTypes.HasData()) {
                ItemTypeList = aItemTypes.ToList();
            } else {
                ItemTypeList = new();
            }
        }
        #endregion
    }
}