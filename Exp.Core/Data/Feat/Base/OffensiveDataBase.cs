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

        #region Methoden
        public void OnNewDay() { }

        public void OnNewBattle() { }

        public void OnNewRound() { }

        public int OnAttackPassiv(params Exp.Data.General.IDamageTypeData[] aDamageTypes) {
            return 0;
        }

        public int OnDamagePassiv(params Exp.Data.General.IDamageTypeData[] aDamageTypes) {
            return 0;
        }

        public int OnAttackActive() {
            return 0;
        }

        public int OnDamageActive() {
            return 0;
        }

        public Exp.Data.General.IDiceTypeData? OverrideDiceType(params Exp.Data.General.IDamageTypeData[] aDamageTypes) {
            return null;
        }

        public Exp.Data.Player.ICharacterSheetData GetExtraBoni(Exp.Data.Player.ICharacterSheetData aCharacterSheet) {
            return aCharacterSheet;
        }

        protected static void AddInstance(IOffensiveData aInstance) {
            Api.Feat.Offensive.Singleton.Add(aInstance);
        }
        #endregion
    }
}