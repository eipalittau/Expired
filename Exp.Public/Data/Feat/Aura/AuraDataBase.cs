using Exp.Data.General.ActionType;
using Exp.Data.General.DamageType;
using Exp.Data.General.DiceType;
using Exp.Data.General.Tier;
using System.Text;

namespace Exp.Data.Feat.Aura {
    public abstract class AuraDataBase : FeatDataBase<IAuraData> {
        #region Properties / Felder
        /// <summary>Ist diese Fähigkeit eine Aktion? (Standard, Bewegung, etc.)</summary>
        public IActionTypeData? ActionType { get; set; }
        #endregion

        #region Konstruktor
        protected AuraDataBase(string aID, int aSortWeight, ITierData aTier, IActionTypeData aActionType, params IAuraData[] aPrerequisites)
            : this(aID, aSortWeight, aTier, aPrerequisites)
            => ActionType = aActionType;

        protected AuraDataBase(string aID, int aSortWeight, ITierData aTier, params IAuraData[] aPrerequisites)
            : base(aID, aSortWeight, aTier, aPrerequisites) { }
        #endregion

        #region Methoden
        public new string GetFullDescription() {
            StringBuilder lDescription = base.GetFullDescription();

            if (ActionType != null) {
                lDescription.AppendLine(string.Empty);
                lDescription.AppendLine("Action-Type:");
                lDescription.AppendLine($"{ActionType.GetName()} ({ActionType.LoreDescription.Get(Util.Localisation.Language)})");
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

        protected static void AddInstance(IAuraData aInstance) {
            Api.Feat.Aura.Singleton.Add(aInstance);
        }
        #endregion
    }
}