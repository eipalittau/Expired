using Exp.Data.Item;

namespace Exp.DefaultMod.Item.Effect {
    internal abstract class EffectDataBase : DataBase, IEffectDataBase {
        #region Properties / Felder
        public float Value { get; set; }
        #endregion

        #region Konstruktor
        private protected EffectDataBase(string aID, int aSortWeight)
            : base(aID, aSortWeight) { }

        #endregion
    }
}