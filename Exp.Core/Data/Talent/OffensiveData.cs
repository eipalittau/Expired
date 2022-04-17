namespace Exp.Data.Talent {
    public sealed class OffensiveData : TalentDataBase<OffensiveData> {
        #region Konstruktor
        internal OffensiveData(string aID, int aSortWeight, int aTier)
            : base(aID, aSortWeight, aTier, null) { }

        internal OffensiveData(string aID, int aSortWeight, int aTier, General.ActionTypeEnum aActionType)
            : base(aID, aSortWeight, aTier, aActionType) { }

        internal OffensiveData(string aID, int aSortWeight, int aTier, params OffensiveData[] aPrerequisites)
            : base(aID, aSortWeight, aTier, null, aPrerequisites) { }

        internal OffensiveData(string aID, int aSortWeight, int aTier, General.ActionTypeEnum aActionType, params OffensiveData[] aPrerequisites)
            : base(aID, aSortWeight, aTier, aActionType, aPrerequisites) { }
        #endregion
    }
}