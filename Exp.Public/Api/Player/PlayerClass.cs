using Exp.Data.Player.PlayerClass;

namespace Exp.Api.Player {
    public sealed class PlayerClass : ApiBase<IPlayerClassData> {
        #region Properties / Felder
        public static PlayerClass Singleton { get; } = new();
        #endregion

        #region Konstruktor
        private PlayerClass() : base() { }
        #endregion

        #region Methoden
        public new IPlayerClassData GetRandom() {
            return base.GetRandom();
        }

        public new void Remove(string aID) {
            base.Remove(aID);
        }

        public new void Clear() {
            base.Clear();
        }

        public new IList<IPlayerClassData> Enumerate() {
            return base.Enumerate();
        }

        public new IPlayerClassData Get(string aID) {
            return base.Get(aID);
        }

        public new int Count() {
            return base.Count();
        }

        public new void Add(IPlayerClassData aItem) {
            base.Add(aItem);
        }
        #endregion
    }
}