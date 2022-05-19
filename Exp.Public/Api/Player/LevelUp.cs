using Exp.Data.Player.LevelUp;

namespace Exp.Api.Player {
    public sealed class LevelUp : ApiBase<ILevelUpData> {
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

        public new IList<ILevelUpData> Enumerate() {
            return base.Enumerate();
        }

        public ILevelUpData Get(General.TargetEffectEnum aChanger) {
            return base.Get(aChanger.Name);
        }

        public new int Count() {
            return base.Count();
        }

        public new void Add(ILevelUpData aItem) {
            base.Add(aItem);
        }
        #endregion
    }
}