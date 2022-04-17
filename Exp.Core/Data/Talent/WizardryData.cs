namespace Exp.Data.Talent {
    public sealed class WizardryData : TalentDataBase<WizardryData> {
        #region Konstruktor
        internal WizardryData(string aID, int aSortWeight, int aTier)
            : base(aID, aSortWeight, aTier, null) { }

        internal WizardryData(string aID, int aSortWeight, int aTier, General.ActionTypeEnum aActionType)
            : base(aID, aSortWeight, aTier, aActionType) { }

        internal WizardryData(string aID, int aSortWeight, int aTier, params WizardryData[] aPrerequisites)
            : base(aID, aSortWeight, aTier, null, aPrerequisites) { }

        internal WizardryData(string aID, int aSortWeight, int aTier, General.ActionTypeEnum aActionType, params WizardryData[] aPrerequisites)
            : base(aID, aSortWeight, aTier, aActionType, aPrerequisites) { }
        #endregion
    }
}