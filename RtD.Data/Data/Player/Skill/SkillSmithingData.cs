namespace RtD.Data {
    public sealed class SkillSmithingData : SkillDataBase {
        #region Properties / Felder
        public List<SmithingEnum> SmithingList { get; } = new List<SmithingEnum>();
        #endregion
        
        #region Konstruktor
        public SkillSmithingData() : base() { }
        #endregion

        #region Methoden
        public void Increase(SmithingEnum aSmithing) {
            if (aSmithing == null) {
                throw new Exception(""); // Patrik: Exception
            }
            if (SmithingList.Contains(aSmithing)) {
                throw new Exception(""); // Patrik: Exception
            }

            base.Increase();
            SmithingList.Add(aSmithing);
        }
        #endregion
    }
}