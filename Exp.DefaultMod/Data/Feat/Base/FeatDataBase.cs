namespace Exp.DefaultMod {
    internal abstract class FeatDataBase<T> : DataBase, Exp.Data.Feat.IFeatDataBase<T> {
        #region Properties / Felder
        /// <summary>Stufe der Fähigkeit.</summary>
        public Exp.Data.General.TierEnum Tier { get; set; }
        /// <summary>Ist diese Fähigkeit eine Aktion? (Standard, Bewegung, etc.)</summary>
        public Exp.Data.General.ActionTypeEnum? ActionType { get; set; }
        /// <summary>Liste der Voraussetzungen.</summary>
        public List<T> PrerequisiteList { get; init; }
        #endregion

        #region Konstruktor
        private protected FeatDataBase(string aID, int aSortWeight, Exp.Data.General.TierEnum aTier, Exp.Data.General.ActionTypeEnum? aActionType, params T[] aPrerequisites)
            : base(aID, aSortWeight) {
            Tier = aTier;
            ActionType = aActionType;
            if (aPrerequisites == null || aPrerequisites.Length == 0) {
                PrerequisiteList = new();
            } else {
                PrerequisiteList = aPrerequisites.ToList();
            }
        }
        #endregion
    }
}