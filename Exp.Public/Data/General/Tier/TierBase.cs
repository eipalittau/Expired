using System.Drawing;

namespace Exp.Data.General.Tier {
    public abstract class TierBase : DataBase {
        #region Properties / Felder
        public int Tier { get; set; }
        public Color Color { get; set; }
        #endregion

        #region Konstruktor
        protected TierBase(string aID, int aSortWeight, int aTier, Color aColor)
            : base(aID, aSortWeight)
            => (Tier, Color) = (aTier, aColor);
        #endregion

        #region Methoden
        protected static void AddInstance(ITierData aInstance) {
            Api.General.Tier.Singleton.Add(aInstance);
        }
        #endregion
    }
}