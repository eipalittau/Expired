using Exp.Data.General;
using Exp.Extension;
using Exp.Util;

namespace Exp.Data.Feat {
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public abstract class FeatDataBase<T> : DataBase {
        #region Properties / Felder
        /// <summary>Stufe der Fähigkeit.</summary>
        public General.ITierData Tier { get; set; }
        /// <summary>Liste der Voraussetzungen.</summary>
        public List<T> PrerequisiteList { get; init; }
        public LanguageBasedData EffektDescription { get; } = new();
        #endregion

        #region Konstruktor
        private protected FeatDataBase(string aID, int aSortWeight, ITierData aTier, params T[] aPrerequisites)
            : base(aID, aSortWeight) {
            Tier = aTier;
            if (aPrerequisites == null || aPrerequisites.Length == 0) {
                PrerequisiteList = new();
            } else {
                PrerequisiteList = aPrerequisites.ToList();
            }
        }

        private protected FeatDataBase(string aID, int aSortWeight, ITierData aTier)
            : base(aID, aSortWeight)
            => (Tier, PrerequisiteList) = (aTier, new());
        #endregion

        #region Methoden
        protected bool CheckDamageType(IDamageTypeData aNeededDamageType, params IDamageTypeData[] aDamageTypes) {
            if (aDamageTypes.HasData()) {
                return aDamageTypes.Contains(Api.General.DamageType.Singleton.Get(aNeededDamageType.ID));
            } else {
                ExceptionHandler.Add(new Exception.MissingParameterException(nameof(aDamageTypes)));
            }
            
            return false;
        }
        #endregion
    }
}