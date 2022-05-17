namespace Exp.Util {
    internal class JsonModSort : Filesystem.JsonBase<List<JsonModSort.ModSortData>> {
        #region Properties / Felder
        public new List<ModSortData> Json { 
            get {
                return base.Json;
            } 
        }
        #endregion

        #region Konstruktor
        public JsonModSort(FileInfo aConfigPathFile) : base(aConfigPathFile, false) { }
        #endregion

        #region Methoden
        public new void Save() {
            base.Save();
        }
        #endregion

        public class ModSortData {
            public string Filename { get; set; } = string.Empty;
            public int SortWeight { get; set; } = 0;
            public bool IsActive { get; set; } = false;

        }
    }
}