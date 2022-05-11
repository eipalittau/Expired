namespace Exp.Data.Feat {
    public abstract class HiddenDataBase : FeatDataBase<IHiddenData> {
        #region Properties / Felder
        /// <summary>Ist diese Fähigkeit eine Aktion? (Standard, Bewegung, etc.)</summary>
        public General.IActionTypeData? ActionType { get; set; }
        #endregion

        #region Konstruktor
        protected HiddenDataBase(string aID, int aSortWeight, General.IActionTypeData? aActionType, params IDefensiveData[] aPrerequisites)
            : base(aID, aSortWeight, aTier, aPrerequisites)
            => ActionType = aActionType;
        #endregion

        #region Methoden
        protected static void AddInstance(IHiddenData aInstance) {
            Api.Feat.Hidden.Singleton.Add(aInstance);
        }
        #endregion
    }
}