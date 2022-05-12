namespace Exp.Api.Player {
    public sealed class LevelUp : ApiBase<Data.Player.ILevelUpData> {
        #region Properties / Felder
        public static LevelUp Singleton { get; } = new();
        #endregion

        #region Konstruktor
        private LevelUp() : base() { }
        #endregion

        #region Methoden
        public bool Contains(General.TargetEffectEnum aChanger) {
            return base.Contains(aChanger.Name);
        }

        public new void Remove(string aID) {
            base.Remove(aID);
        }

        public new void Clear() {
            base.Clear();
        }

        public new IList<Data.Player.ILevelUpData> Enumerate() {
            return base.Enumerate();
        }

        public Data.Player.ILevelUpData Get(General.TargetEffectEnum aChanger) {
            return base.Get(aChanger.Name);
        }

        public new int Count() {
            return base.Count();
        }

        public new void Add(Data.Player.ILevelUpData aItem) {
            base.Add(aItem);
        }
        #endregion
    }
}