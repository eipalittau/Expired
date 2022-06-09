using Exp.Data.Misc.Recollection;

namespace Exp.Core.EventArgs {
    public class NewRecollectionEventArgs {
        #region Properties / Felder
        public bool IsRecollectionKnown { get; init; }
        public IRecollectionData Item { get; init; }
        #endregion

        #region Konstruktor
        public NewRecollectionEventArgs(bool aIsRecollectionKnown, IRecollectionData aItem) {
            IsRecollectionKnown = aIsRecollectionKnown;
            Item = aItem;
        }
        #endregion
    }
}