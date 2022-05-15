using System.Reflection;

namespace Exp.Util {
    public class ModData {
        #region Properties / Felder
        public string Name { get; init; }
        public string Description { get; set; } = string.Empty;
        public string Version { get; init; } = string.Empty;
        public int SortWeight { get; set; }
        public FileInfo PathFile { get; init; }
        public dynamic? Instance { get; set; }
        public bool IsActive { get; set; }
        public bool IsLoaded { get; private set; }
        #endregion

        #region Konstruktor
        public ModData(FileInfo aPathFile) {
            Name = aPathFile.Name;
            PathFile = aPathFile;
        }
        #endregion
    }
}