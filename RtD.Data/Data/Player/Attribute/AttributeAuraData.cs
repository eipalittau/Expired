namespace RtD.Data {
    public sealed class AttributeAuraData : AttributeDataBase<AuraTalentEnum> {
        #region Properties / Felder
        public int HPPerLevel { get; private set; }
        #endregion

        #region Konstruktor
        public AttributeAuraData() : base() { }
        #endregion

        #region Methoden
        public new void Increase(AuraTalentEnum aTalent) {
            base.Increase(aTalent);
            HPPerLevel = base.Progress;
        }
        #endregion
    }
}