using Exp.Extension;

namespace Exp.Data.Feat {
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public abstract class FeatDataBase<T> : DataBase {
        #region Properties / Felder
        /// <summary>Stufe der Fähigkeit.</summary>
        public General.ITierData Tier { get; set; }
        /// <summary>Liste der Voraussetzungen.</summary>
        public List<T> PrerequisiteList { get; init; }
        public Util.LanguageBasedData EffektDescription { get; } = new Util.LanguageBasedData();
        #endregion

        #region Konstruktor
        private protected FeatDataBase(string aID, int aSortWeight, General.ITierData aTier, params T[] aPrerequisites)
            : base(aID, aSortWeight) {
            Tier = aTier;
            if (aPrerequisites == null || aPrerequisites.Length == 0) {
                PrerequisiteList = new();
            } else {
                PrerequisiteList = aPrerequisites.ToList();
            }
        }

        private protected FeatDataBase(string aID, int aSortWeight, General.ITierData aTier)
            : base(aID, aSortWeight)
            => (Tier, PrerequisiteList) = (aTier, new());
        #endregion

        #region Methoden
        protected bool CheckDamageType(General.IDamageTypeData aNeededDamageType, params General.IDamageTypeData[] aDamageTypes) {
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