namespace Exp.Data.Talent {
    public sealed class AuraData : TalentDataBase<AuraData> {
        #region Konstruktor
        internal AuraData(string aID, int aSortWeight, int aTier)
            : base(aID, aSortWeight, aTier, null) { }

        internal AuraData(string aID, int aSortWeight, int aTier, General.ActionTypeEnum aActionType)
            : base(aID, aSortWeight, aTier, aActionType) { }

        internal AuraData(string aID, int aSortWeight, int aTier, params AuraData[] aPrerequisites)
            : base(aID, aSortWeight, aTier, null, aPrerequisites) { }

        internal AuraData(string aID, int aSortWeight, int aTier, General.ActionTypeEnum aActionType, params AuraData[] aPrerequisites)
            : base(aID, aSortWeight, aTier, aActionType, aPrerequisites) { }
        #endregion
    }
}