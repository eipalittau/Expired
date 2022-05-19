using Exp.Data.General.ActionType;
using Exp.Data.General.Tier;

namespace Exp.Data.Feat.Defensive {
    public abstract class DefensiveDataBase : FeatDataBase<IDefensiveData> {
        #region Properties / Felder
        /// <summary>Ist diese Fähigkeit eine Aktion? (Standard, Bewegung, etc.)</summary>
        public IActionTypeData? ActionType { get; set; }
        #endregion

        #region Konstruktor
        protected DefensiveDataBase(string aID, int aSortWeight, ITierData aTier, IActionTypeData aActionType, params IDefensiveData[] aPrerequisites)
            : this(aID, aSortWeight, aTier, aPrerequisites)
            => ActionType = aActionType;
        protected DefensiveDataBase(string aID, int aSortWeight, ITierData aTier, params IDefensiveData[] aPrerequisites)
            : base(aID, aSortWeight, aTier, aPrerequisites) { }
        #endregion

        #region Methoden
        protected static void AddInstance(IDefensiveData aInstance) {
            Api.Feat.Defensive.Singleton.Add(aInstance);
        }
        #endregion
    }
}