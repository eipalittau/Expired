namespace Exp.Data.Talent {
    public sealed class DefensiveData : TalentDataBase<DefensiveData> {
        #region Konstruktor
        internal DefensiveData(string aID, int aSortWeight, int aTier)
            : base(aID, aSortWeight, aTier, null) { }

        internal DefensiveData(string aID, int aSortWeight, int aTier, General.ActionTypeEnum aActionType)
            : base(aID, aSortWeight, aTier, aActionType) { }

        internal DefensiveData(string aID, int aSortWeight, int aTier, params DefensiveData[] aPrerequisites)
            : base(aID, aSortWeight, aTier, null, aPrerequisites) { }

        internal DefensiveData(string aID, int aSortWeight, int aTier, General.ActionTypeEnum aActionType, params DefensiveData[] aPrerequisites)
            : base(aID, aSortWeight, aTier, aActionType, aPrerequisites) { }
        #endregion
    }
}