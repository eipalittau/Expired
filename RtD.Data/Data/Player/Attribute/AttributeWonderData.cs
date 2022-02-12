namespace RtD.Data {
    public sealed class AttributeWonderData : AttributeDataBase<WonderTalentEnum> {
        #region Properties / Felder
        public int WonderLevel { get; private set; }
        #endregion

        #region Konstruktor
        public AttributeWonderData() : base() { }
        #endregion

        #region Methoden
        public new void Increase(WonderTalentEnum aTalent) {
            WonderLevel = base.Increase(aTalent);
        }
        #endregion
    }
}