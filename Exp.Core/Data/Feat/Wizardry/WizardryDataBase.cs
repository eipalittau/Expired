using Exp.Data.General.ActionType;
using Exp.Data.General.Tier;

namespace Exp.Data.Feat.Wizardry {
    public abstract class WizardryDataBase : FeatDataBase<IWizardryData> {
        #region Properties / Felder
        /// <summary>Ist diese Fähigkeit eine Aktion? (Standard, Bewegung, etc.)</summary>
        public IActionTypeData? ActionType { get; set; }
        #endregion

        #region Konstruktor
        protected WizardryDataBase(string aID, int aSortWeight, ITierData aTier, IActionTypeData aActionType, params IWizardryData[] aPrerequisites)
            : this(aID, aSortWeight, aTier, aPrerequisites)
            => ActionType = aActionType;

        protected WizardryDataBase(string aID, int aSortWeight, ITierData aTier, params IWizardryData[] aPrerequisites)
            : base(aID, aSortWeight, aTier, aPrerequisites) { }
        #endregion

        #region Methoden
        protected static void AddInstance(IWizardryData aInstance) {
            Api.Feat.Wizardry.Singleton.Add(aInstance);
        }
        #endregion
    }
}