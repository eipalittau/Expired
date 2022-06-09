using Exp.Api.General;
using System.ComponentModel;

namespace Exp.Core.Sheet {
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public sealed class ExperienceData : SheetBase {
        #region Properties / Felder
        public int Level { get; private set; } = 0;
        #endregion

        #region Konstruktor
        internal ExperienceData(CharacterSheet aMain, int aExperience4LevelUp)
            : base(aMain, true)
            => Max = aExperience4LevelUp;
        #endregion

        #region Methoden
        internal bool LevelUp() {
            if (base.Current < base.Max) {
                if (Level == 0) {
                    Add(base.Max);
                } else {
                    return false;
                }
            }

            Level++;

            return base.LevelUp(TargetEffectEnum.Exp4LevelUp);
        }

        internal void Add(int aPoints) {
            OnIncrease(aPoints, true);
        }
        #endregion
    }
}