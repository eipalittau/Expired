using Exp.Util;

namespace Exp.Data.Profession {
    public abstract class SmithingDataBase : DataBase {
        #region Properties / Felder
        /// <summary>Stufe der Fähigkeit.</summary>
        public General.ITierData Tier { get; set; }
        /// <summary>Liste der Voraussetzungen.</summary>
        public ISmithingData? Prerequisite { get; init; }
        public LanguageBasedData EffektDescription { get; } = new();
        public List<Item.IItemTypeData> ItemTypeList { get; init; } 
        #endregion

        #region Konstruktor
        protected SmithingDataBase(string aID, int aSortWeight, General.ITierData aTier, params Item.IItemTypeData[] aItemTypes)
            : base(aID, aSortWeight) {
            Tier = aTier;
            if (aItemTypes == null || aItemTypes.Length == 0) {
                ItemTypeList = new();
            } else {
                ItemTypeList = aItemTypes.ToList();
            }
        }

        protected SmithingDataBase(string aID, int aSortWeight, General.ITierData aTier, ISmithingData aPrerequisite, params Item.IItemTypeData[] aItemTypes)
            : this(aID, aSortWeight, aTier, aItemTypes)
            => Prerequisite = aPrerequisite;
        #endregion

        #region Methoden
        protected static void AddInstance(ISmithingData aInstance) {
            Api.Profession.Smithing.Singleton.Add(aInstance);
        }
        #endregion
    }
}