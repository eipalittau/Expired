namespace RtD.Data {
    public sealed class AttributeWizardryData : AttributeDataBase<WizardryTalentEnum> {
        #region Properties / Felder
        public int WizardryLevel { get; private set; }
        #endregion

        #region Konstruktor
        public AttributeWizardryData() : base() { }
        #endregion

        #region Methoden
        public new void Increase(WizardryTalentEnum aTalent) {
            WizardryLevel = base.Increase(aTalent);
        }
        #endregion
    }
}