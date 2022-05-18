using Exp.Data.General.DamageType;
using Exp.Data.General.Tier;
using Exp.Util;
using Exp.Util.Extension;
using System.Text;

namespace Exp.Data.Feat {
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public abstract class FeatDataBase<T> : DataBase {
        #region Properties / Felder
        /// <summary>Stufe der Fähigkeit.</summary>
        public ITierData Tier { get; set; }
        /// <summary>Liste der Voraussetzungen.</summary>
        public List<T> PrerequisiteList { get; init; }
        public LanguageBasedData EffectDescription { get; } = new();
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
        public string GetEffectDescription() {
            return EffectDescription.Get(Localisation.Language);
        }

        protected StringBuilder GetFullDescription() {
            StringBuilder lDescription = new();

            lDescription.AppendLine(GetName());
            lDescription.AppendLine(string.Empty);
            lDescription.AppendLine("Beschreibung:");
            lDescription.AppendLine(GetLoreDescription());
            lDescription.AppendLine(GetEffectDescription());
            lDescription.AppendLine(string.Empty);
            lDescription.AppendLine("Stufe:");
            lDescription.AppendLine(Tier.GetName());

            return lDescription;
        }

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