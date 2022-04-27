using Exp.Extension;

namespace Exp.DefaultMod.Feat {
    public abstract class FeatDataBase<T> : DataBase, Data.Feat.IFeatDataBase<T> {
        #region Properties / Felder
        /// <summary>Stufe der Fähigkeit.</summary>
        public Data.General.ITierData Tier { get; set; }
        /// <summary>Ist diese Fähigkeit eine Aktion? (Standard, Bewegung, etc.)</summary>
        public Data.General.IActionTypeData? ActionType { get; set; }
        /// <summary>Liste der Voraussetzungen.</summary>
        public List<T> PrerequisiteList { get; init; }
        public Util.LanguageBasedData EffektDescription { get; } = new Util.LanguageBasedData();
        #endregion

        #region Konstruktor
        private protected FeatDataBase(string aID, int aSortWeight, Data.General.ITierData aTier, Data.General.IActionTypeData? aActionType, params T[] aPrerequisites)
            : base(aID, aSortWeight) {
            Tier = aTier;
            ActionType = aActionType;
            if (aPrerequisites == null || aPrerequisites.Length == 0) {
                PrerequisiteList = new();
            } else {
                PrerequisiteList = aPrerequisites.ToList();
            }
        }
        #endregion
            
        #region Methoden
        private protected bool CheckDamageType(Data.General.IDamageTypeData aNeededDamageType, params Data.General.IDamageTypeData[] aDamageTypes) {
            if (aDamageTypes.HasData()) {
                throw new Exception.MissingParameterException(nameof(aDamageTypes));
            } else {
                if (aDamageTypes.Contains(Api.General.DamageType.Singleton.Get(aNeededDamageType.ID))) {
                    return true;
                } else {
                    return false;
                }
            }
        }
        #endregion
    }
}
