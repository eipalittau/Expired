using Exp.Data.General.Tier;
using Exp.Data.Item.ItemType;

namespace Exp.Data.Profession.Smithing {
    public abstract class SmithingDataBase : DataBase {
        #region Properties / Felder
        /// <summary>Stufe der Fähigkeit.</summary>
        public ITierData Tier { get; set; }
        /// <summary>Liste der Voraussetzungen.</summary>
        public ISmithingData? Prerequisite { get; init; }
        public Util.LanguageBasedData EffektDescription { get; } = new();
        public List<IItemTypeData> ItemTypeList { get; init; }
        #endregion

        #region Konstruktor
        protected SmithingDataBase(string aID, int aSortWeight, ITierData aTier, params IItemTypeData[] aItemTypes)
            : base(aID, aSortWeight) {
            Tier = aTier;
            if (aItemTypes == null || aItemTypes.Length == 0) {
                ItemTypeList = new();
            } else {
                ItemTypeList = aItemTypes.ToList();
            }
        }

        protected SmithingDataBase(string aID, int aSortWeight, ITierData aTier, ISmithingData aPrerequisite, params IItemTypeData[] aItemTypes)
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