using Exp.Data.Feat.Wizardry;

namespace Exp.Api.Feat {
    public sealed class Wizardry : ApiBase<IWizardryData> {
        #region Properties / Felder
        public static Wizardry Singleton { get; } = new();
        #endregion

        #region Konstruktor
        private Wizardry() : base() { }
        #endregion

        #region Methoden
        public new void Remove(string aID) {
            base.Remove(aID);
        }

        public new void Clear() {
            base.Clear();
        }

        public new IList<IWizardryData> Enumerate() {
            return base.Enumerate();
        }

        public new IWizardryData Get(string aID) {
            return base.Get(aID);
        }

        public new int Count() {
            return base.Count();
        }

        public new void Add(IWizardryData aItem) {
            base.Add(aItem);
        }
        #endregion
    }
}