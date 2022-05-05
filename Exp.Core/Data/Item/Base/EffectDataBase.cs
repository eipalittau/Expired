namespace Exp.Data.Item {
    public abstract class EffectDataBase : DataBase {
        #region Properties / Felder
        public float Value { get; set; }
        #endregion

        #region Konstruktor
        protected EffectDataBase(string aID, int aSortWeight)
            : base(aID, aSortWeight) { }

        #endregion

        #region Methoden
        protected static void AddInstance(IEffectData aInstance) {
            Api.Item.Effect.Singleton.Add(aInstance);
        }
        #endregion
    }
}