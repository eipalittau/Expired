namespace Exp.Data.Feat {
    public abstract class DefensiveDataBase : FeatDataBase<IDefensiveData> {
        #region Properties / Felder
        /// <summary>Ist diese Fähigkeit eine Aktion? (Standard, Bewegung, etc.)</summary>
        public General.IActionTypeData? ActionType { get; set; }
        #endregion

        #region Konstruktor
        protected DefensiveDataBase(string aID, int aSortWeight, General.ITierData aTier, General.IActionTypeData? aActionType, params IDefensiveData[] aPrerequisites)
            : base(aID, aSortWeight, aTier, aPrerequisites)
            => ActionType = aActionType;
        #endregion
    }
}