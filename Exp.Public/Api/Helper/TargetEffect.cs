using Exp.Api.General;
using Exp.Data;
using Exp.Data.Helper;
using Exp.Data.Player;

namespace Exp.Api.Helper {
    public class TargetEffect : DataBase, ITargetEffect {
        #region Properties / Felder
        /// <summary>Anzahl der Runden die dieser Effekt noch anhält.</summary>
        public int LapsRemaining { get; set; }
        /// <summary>Definition des Effektes.</summary>
        public TargetEffectEnum Effect { get; init; }
        /// <summary>Erhöhender Effekt</summary>
        public ModifierData? Increase { get; init; }
        /// <summary>Mindernder Effekt</summary>
        public ModifierData? Decrease { get; init; }
        /// <summary>Kann der gleiche Effekt mehrfach vorkommen?</summary>
        public bool IsStackable { get; init; }
        /// <summary>Gibt es einen Rettungswurf?</summary>
        public bool HasSaving { get; init; }
        /// <summary>Wer hat dies ausgelöst?</summary>
        public ICharacterSheetData? Owner { get; set; }
        #endregion

        #region Konstruktor
        public TargetEffect(string aID, TargetEffectEnum aEffect, bool aIsStackable, bool aHasSaving, ModifierData? aIncrease, ModifierData? aDecrease)
            : this(aID, aEffect, aIsStackable, aHasSaving, 1, aIncrease, aDecrease) { }

        public TargetEffect(string aID, TargetEffectEnum aEffect, bool aIsStackable, bool aHasSaving, int aLapsRemaining, ModifierData? aIncrease, ModifierData? aDecrease)
            : base(aID, 0)
            => (LapsRemaining, Effect, Increase, Decrease, IsStackable, HasSaving) = (aLapsRemaining, aEffect, aIncrease, aDecrease, aIsStackable, aHasSaving);
        #endregion
    }
}