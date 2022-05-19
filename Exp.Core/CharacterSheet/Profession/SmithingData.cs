using Exp.Data.Profession.Smithing;
using Exp.Util;

namespace Exp.Core.Sheet {
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public sealed class SmithingData {
        #region Properties / Felder
        public int Level { get; internal set; }
        public int MaxLevel { get; } = 5;
        private List<ISmithingData> ProfessionList { get; } = new List<ISmithingData>();
        #endregion

        #region Konstruktor
        internal SmithingData() { }
        #endregion

        #region Methoden
        internal int Count() {
            return ProfessionList.Count;
        }

        internal IList<ISmithingData> Enumerate() {
            return ProfessionList.AsReadOnly();
        }

        internal void AddTalent(ISmithingData aProfession) {
            if (ProfessionList.Contains(aProfession)) {
                ExceptionHandler.Add(new Exception.DublicateItemException(aProfession.ID));
            } else {
                ProfessionList.Add(aProfession);
            }
        }
        #endregion
    }
}