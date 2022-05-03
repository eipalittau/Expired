namespace Exp.Data.Feat {
    public abstract class AuraDataBase : FeatDataBase<IAuraData> {
        #region Properties / Felder
        /// <summary>Ist diese Fähigkeit eine Aktion? (Standard, Bewegung, etc.)</summary>
        public General.IActionTypeData? ActionType { get; set; }
        #endregion

        #region Konstruktor
        protected AuraDataBase(string aID, int aSortWeight, General.ITierData aTier, General.IActionTypeData? aActionType, params IAuraData[] aPrerequisites)
            : base(aID, aSortWeight, aTier, aPrerequisites) 
            => ActionType = aActionType;
        #endregion

        #region Methoden
        public void OnNewDay() { }

        public void OnNewBattle() { }

        public void OnNewRound() { }

        public int OnAttackPassiv(params General.IDamageTypeData[] aDamageTypes) {
            return 0;
        }

        public int OnDamagePassiv(params General.IDamageTypeData[] aDamageTypes) {
            return 0;
        }

        public int OnAttackActive() {
            return 0;
        }

        public int OnDamageActive() {
            return 0;
        }

        public General.IDiceTypeData? OverrideDiceType(params General.IDamageTypeData[] aDamageTypes) {
            return null;
        }
        #endregion
    }
}