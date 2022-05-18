using Exp.Util.Filesystem;

namespace Exp.Internal.Mod {
    internal class JsonModSortHandler : JsonBase<List<JsonModSortData>> {
        #region Properties / Felder
        public new List<JsonModSortData> Json {
            get {
                return base.Json;
            }
        }
        #endregion

        #region Konstruktor
        public JsonModSortHandler(FileInfo aConfigPathFile) : base(aConfigPathFile, false) { }
        #endregion

        #region Methoden
        public new void Save() {
            base.Save();
        }
        #endregion
    }
}