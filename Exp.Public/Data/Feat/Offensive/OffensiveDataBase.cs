using Exp.Data.General.ActionType;
using Exp.Data.General.DamageType;
using Exp.Data.General.DiceType;
using Exp.Data.General.Tier;
using Exp.Data.Feat;
using System.Text;

namespace Exp.Data.Feat.Offensive {
    public abstract class OffensiveDataBase : FeatDataBase<IOffensiveData> {
        #region Properties / Felder
        /// <summary>Ist diese Fähigkeit eine Aktion? (Standard, Bewegung, etc.)</summary>
        public IActionTypeData? ActionType { get; set; }
        #endregion

        #region Konstruktor
        protected OffensiveDataBase(string aID, int aSortWeight, ITierData aTier, IActionTypeData aActionType, params IOffensiveData[] aPrerequisites)
            : this(aID, aSortWeight, aTier, aPrerequisites)
            => ActionType = aActionType;

        protected OffensiveDataBase(string aID, int aSortWeight, ITierData aTier, params IOffensiveData[] aPrerequisites)
            : base(aID, aSortWeight, aTier, aPrerequisites) { }
        #endregion

        #region Methoden
        public new string GetFullDescription() {
            StringBuilder lDescription = base.GetFullDescription();

            if (ActionType != null) {
                lDescription.AppendLine(string.Empty);
                lDescription.AppendLine("Action-Type:");
                lDescription.AppendLine($"{ActionType.GetName()} ({ActionType.GetLoreDescription()})");
            }

            if (PrerequisiteList.Count > 0) {
                lDescription.AppendLine(string.Empty);
                PrerequisiteList.ForEach(x => lDescription.AppendLine($"- {x.GetName()}"));
            }

            return lDescription.ToString();
        }

        public void OnNewDay() { }

        public void OnNewBattle() { }

        public void OnNewRound() { }

        public int OnAttackPassiv(params IDamageTypeData[] aDamageTypes) {
            return 0;
        }

        public int OnDamagePassiv(params IDamageTypeData[] aDamageTypes) {
            return 0;
        }

        public int OnAttackActive() {
            return 0;
        }

        public int OnDamageActive() {
            return 0;
        }

        public IDiceTypeData? OverrideDiceType(params IDamageTypeData[] aDamageTypes) {
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