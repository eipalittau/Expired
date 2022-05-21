﻿using Exp.Data.General.ActionType;
using Exp.Data.General.Tier;
using System.Text;

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

        protected static void AddInstance(IDefensiveData aInstance) {
            Api.Feat.Defensive.Singleton.Add(aInstance);
        }
        #endregion
    }
}