namespace RtD.Data {
    public sealed class SkillRecollectionData : SkillDataBase {
        #region Properties / Felder
        public List<RecollectionEnum> RecollectionList { get; } = new List<RecollectionEnum>();
        #endregion

        #region Konstruktor
        public SkillRecollectionData() : base() { }
        #endregion

        #region Methoden
        public new void Increase() {
            base.Increase();
        }

        public void Add(int aValue) {
            RecollectionEnum? lItem = RecollectionEnum.Get(aValue);

            if (lItem == null) {
                throw new ArgumentException(""); //Patrik: Exception
            }

            RecollectionList.Add(lItem);
        }
        #endregion
    }
}