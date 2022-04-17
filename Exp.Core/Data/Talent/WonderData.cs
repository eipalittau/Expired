namespace Exp.Data.Talent {
    public sealed class WonderData : TalentDataBase<WonderData> {
        #region Konstruktor
        internal WonderData(string aID, int aSortWeight, int aTier)
            : base(aID, aSortWeight, aTier, null) { }

        internal WonderData(string aID, int aSortWeight, int aTier, General.ActionTypeEnum aActionType)
            : base(aID, aSortWeight, aTier, aActionType) { }

        internal WonderData(string aID, int aSortWeight, int aTier, params WonderData[] aPrerequisites)
            : base(aID, aSortWeight, aTier, null, aPrerequisites) { }

        internal WonderData(string aID, int aSortWeight, int aTier, General.ActionTypeEnum aActionType, params WonderData[] aPrerequisites)
            : base(aID, aSortWeight, aTier, aActionType, aPrerequisites) { }
        #endregion
    }
}