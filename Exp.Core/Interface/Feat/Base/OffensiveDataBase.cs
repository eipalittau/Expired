namespace Exp.Data.Feat {
    public abstract class OffensiveDataBase : FeatDataBase<IOffensiveData> {
        #region Properties / Felder
        /// <summary>Ist diese Fähigkeit eine Aktion? (Standard, Bewegung, etc.)</summary>
        public General.IActionTypeData? ActionType { get; set; }
        #endregion

        #region Konstruktor
        protected OffensiveDataBase(string aID, int aSortWeight, General.ITierData aTier, General.IActionTypeData? aActionType, params IOffensiveData[] aPrerequisites)
            : base(aID, aSortWeight, aTier, aPrerequisites)
            => ActionType = aActionType;
        #endregion
    }
}