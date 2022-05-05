namespace Exp.Data.Feat {
    public abstract class WonderDataBase : FeatDataBase<IWonderData> {
        #region Properties / Felder
        /// <summary>Ist diese Fähigkeit eine Aktion? (Standard, Bewegung, etc.)</summary>
        public General.IActionTypeData? ActionType { get; set; }
        #endregion

        #region Konstruktor
        protected WonderDataBase(string aID, int aSortWeight, General.ITierData aTier, General.IActionTypeData aActionType, params IWonderData[] aPrerequisites)
            : base(aID, aSortWeight, aTier, aPrerequisites)
            => ActionType = aActionType;

        protected WonderDataBase(string aID, int aSortWeight, General.ITierData aTier, params IWonderData[] aPrerequisites)
            : base(aID, aSortWeight, aTier, aPrerequisites) { }
        #endregion

        #region Methoden
        protected static void AddInstance(IWonderData aInstance) {
            Api.Feat.Wonder.Singleton.Add(aInstance);
        }
        #endregion
    }
}