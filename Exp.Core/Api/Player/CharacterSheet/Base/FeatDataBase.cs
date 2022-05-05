namespace Exp.Api.Player.Sheet {
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public abstract class FeatDataBase<T> where T : Data.IDataBase {
        #region Properties / Felder
        public int Level { get; private set; } = 0;
        public int MaxLevel { get; protected set; } = 10;
        private List<T> TalentList { get; } = new List<T>();
        #endregion

        #region Konstruktor
        private protected FeatDataBase() { }
        #endregion

        #region Methoden
        public int Count() {
            return TalentList.Count;
        }

        private protected IList<T> Enumerate() {
            return TalentList.AsReadOnly();
        }

        private protected void AddTalent(T aTalent) {
            if (TalentList.Contains(aTalent)) {
                throw new Exception.DublicateItemException(aTalent.ID);
            } else {
                TalentList.Add(aTalent);
            }
        }

        private protected void LevelUp(T aTalent) {
            AddTalent(aTalent);
            Level++;
        }
        #endregion
    }
}