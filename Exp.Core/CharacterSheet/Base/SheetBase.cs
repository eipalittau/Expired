using Exp.Api.General;
using Exp.Api.Helper;
using System.ComponentModel;

namespace Exp.Core.Sheet {
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public abstract class SheetBase {
        #region Properties / Felder
        public int Max { get; internal set; }
        public int Current { get; private set; }
        public int Temp { get; internal set; }
        internal CharacterSheet Main { get; init; }
        private bool IgnoreDeath { get; init; }
        #endregion

        #region Konstruktor0
        private protected SheetBase(CharacterSheet aMain)
            : this(aMain, false) { }

        private protected SheetBase(CharacterSheet aMain, bool aIgnoreDeath)
            => (Main, IgnoreDeath) = (aMain, aIgnoreDeath);
        #endregion

        #region Methoden
        internal bool LevelUp(TargetEffectEnum aEffect) {
            OnDecrease(Max);
            Max = CalcMax(aEffect);

            return true;
        }

        #region OnDecrease
        private protected void OnDecrease(int aPoints) {
            OnDecrease(aPoints, false);
        }

        private protected void OnDecrease(int aPoints, bool aCanDie) {
            if (Current > aPoints) {
                Current -= aPoints;
            } else {
                Current = 0;
                if (aCanDie) {
                    Main.IsDead = true;
                }
            }
        }
        #endregion

        #region OnIncrease
        private protected void OnIncrease() {
            OnIncrease(1);
        }

        private protected void OnIncrease(int aPoints) {
            OnIncrease(aPoints, false);
        }

        private protected void OnIncrease(int aPoints, bool aForceOverMax) {
            if (!Main.IsDead || IgnoreDeath) {
                Current += aPoints;

                if (Current > Max + Temp && !aForceOverMax) {
                    Current = Max + Temp;
                }
            }
        }
        #endregion

        internal void OnNewDay() {
            Current = Max + Temp;
        }

        private int CalcMax(TargetEffectEnum aEffect) {
            int lResult = 0;

            // Änderung durch Level-Up
            if (Api.Player.LevelUp.Singleton.Contains(aEffect)) {
                lResult = Api.Player.LevelUp.Singleton.Get(aEffect).Base.Value * Main.Experience.Level;
            }

            // Änderung durch Charakterklasse (Aptitude)
            Data.Misc.Aptitude.IAptitudeData? lAptitude = Main.PlayerClass.GetAptitude(aEffect);

            if (lAptitude != null) {
                if (lAptitude.Base.HasData) {
                    lResult = lAptitude.Base.Value * Main.Experience.Level;
                }

                lResult += IncreaseModifierData(lAptitude.Modifier, 0);
                lResult *= IncreaseModifierData(lAptitude.Multiplicator, 1);
                lResult /= IncreaseModifierData(lAptitude.Divisor, 1);
            }

            // Änderung durch Feat
            // Patrik: Änderung durch Feat

            // Änderung durch Skill
            // Patrik: Änderung durch Skill

            return lResult;
        }

        private int IncreaseModifierData(ModifierData aModifier, int aDefault) {
            if (aModifier.HasData) {
                return aModifier.GetValueByLevel(Main.Experience.Level);
            } else {
                return aDefault;
            }
        }
        #endregion
    }
}