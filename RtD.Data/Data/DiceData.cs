namespace RtD.Data {
    public sealed class DiceData {
        #region Properties / Felder
        public DiceEnum Faces { get; set; } = DiceEnum.None;
        public byte Count { get; set; } = 0;
        #endregion

        #region Konstruktor
        internal DiceData(Json.DiceJsonData? aData) {
            if (aData != null) {
                Faces = DiceEnum.Convert(aData.Faces);
                Count = (byte)aData.Count;
            }
        }

        public DiceData() { }

        public DiceData(DiceEnum aFaces, byte aCount)
            => (Faces, Count) = (aFaces, aCount);
        #endregion

        #region Methoden
        public int Roll() {
            int lResult = 0;

            for (int lI = 0; lI <= Count; lI++) {
                lResult += Faces.Roll();
            }

            return lResult;
        }
        #endregion
    }
}