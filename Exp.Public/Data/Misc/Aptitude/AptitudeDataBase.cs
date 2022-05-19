using Exp.Api.General;
using Exp.Api.Helper;
using Exp.Data.General.ActionType;
using Exp.Data.Helper;

namespace Exp.Data.Misc.Aptitude {
    public abstract class AptitudeDataBase : DataBase {
        #region Properties / Felder
        protected List<ITargetEffect> EffectList { get; } = new();
        public ModifierData Base { get; init; } = new(0, 0, 0);
        public ModifierData Modifier { get; init; } = new(0, 0, 0);
        public ModifierData Multiplicator { get; init; } = new(1, 0, 1);
        public ModifierData Divisor { get; init; } = new(1, 0, 1);
        public TargetEffectEnum Effect { get; init; }
        public IActionTypeData? ActionType { get; init; }
        #endregion

        #region Konstruktor
        protected AptitudeDataBase(string aID, TargetEffectEnum aEffect, IActionTypeData aActionType)
            : this(aID, aEffect)
            => ActionType = aActionType;

        protected AptitudeDataBase(string aID, TargetEffectEnum aEffect)
            : base(aID, 0)
            => Effect = aEffect;
        #endregion

        #region Methoden
        public IList<ITargetEffect> Execute() {
            return EffectList.AsReadOnly();
        }
        #endregion
    }
}