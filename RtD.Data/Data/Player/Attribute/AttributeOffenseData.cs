namespace RtD.Data {
    public sealed class AttributeOffenseData : AttributeDataBase<OffensiveTalentsEnum> {
        #region Properties / Felder
        public int Attack { get; private set; }
        public int Damage { get; private set; }
        #endregion

        #region Konstruktor
        public AttributeOffenseData() : base() { }
        #endregion

        #region Methoden
        public new void Increase(OffensiveTalentsEnum aTalent) {
            Attack = Damage = base.Increase(aTalent);
        }
        #endregion
    }
}