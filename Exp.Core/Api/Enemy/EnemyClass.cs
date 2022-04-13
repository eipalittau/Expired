namespace Exp.Api.Enemy {
    public sealed class EnemyClass : Base<Data.Enemy.EnemyClassData> {
        #region Properties / Felder
        private static int mID = 0;
        #endregion

        #region Konstruktor
        internal EnemyClass() : base() {
            Add("Kämpfer", "", 100);
            Add("Kleriker", "", 300);
            Add("Schurke", "", 200);
            Add("Magier", "", 400);
        }
        #endregion

        #region Methoden
        public void Add(int aID, string aName, string aDescription, int aInitiative) {
            Add(aID, aName, aDescription, (uint)base.Count() + 1, aInitiative);
        }

        public void Add(int aID, string aName, string aDescription, uint aSortOrder, int aInitiative) {
            Add(aID, aName, aDescription, aSortOrder, base.GetOriginNameCaller(), aInitiative);
        }

        private void Add(string aName, string aDescription, int aInitiative) {
            Add(++mID, aName, aDescription, (uint)base.Count() + 1, base.GetOriginNameExecuting(), aInitiative);
        }

        private void Add(int aID, string aName, string aDescription, uint aSortOrder, string aOrigin, int aInitiative) {
            if (base.ItemExists(aID, aName)) {
                // Patrik: Throw Dublicate Exception
            } else {
                base.Add(new Data.Enemy.EnemyClassData(aID, aName, aDescription, aSortOrder, aOrigin, aInitiative));
            }
        }
        #endregion
    }
}