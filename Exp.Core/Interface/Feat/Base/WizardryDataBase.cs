namespace Exp.Data.Feat {
    public abstract class WizardryDataBase : FeatDataBase<IWizardryData> {
        #region Properties / Felder
        /// <summary>Ist diese Fähigkeit eine Aktion? (Standard, Bewegung, etc.)</summary>
        public General.IActionTypeData? ActionType { get; set; }
        #endregion

        #region Konstruktor
        protected WizardryDataBase(string aID, int aSortWeight, General.ITierData aTier, General.IActionTypeData? aActionType, params IWizardryData[] aPrerequisites)
            : base(aID, aSortWeight, aTier, aPrerequisites)
            => ActionType = aActionType;
        #endregion
    }
}