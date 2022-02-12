namespace RtD.Data {
    public sealed class AttributeDefenseData : AttributeDataBase<DefensiveTalentEnum> {
        #region Properties / Felder
        public int ArmorClass { get; private set; }
        #endregion

        #region Konstruktor
        public AttributeDefenseData() : base() { }
        #endregion

        #region Methoden
        public new void Increase(DefensiveTalentEnum aTalent) {
            ArmorClass = base.Increase(aTalent);
        }
        #endregion
    }
}