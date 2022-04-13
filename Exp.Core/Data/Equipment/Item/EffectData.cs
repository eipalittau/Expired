namespace Exp.Data.Equipment {
    public sealed class EffectData : DataBase {
        #region Properties / Felder
        public int Primary { get; set; }
        public int Secondary { get; set; }
        #endregion

        #region Konstruktor
        internal EffectData(int aID, string aName, string aDescription, uint aSortOrder, string aOrigin, int aPrimary, int aSecondary)
            : base(aID, aName, aDescription, aSortOrder, aOrigin)
            => (Primary, Secondary) = (aPrimary, aSecondary);
        #endregion
    }
}