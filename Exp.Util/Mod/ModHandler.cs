using System.Reflection;
using System.Text.Json;

namespace Exp.Util {
    public class ModHandler {
        #region Properties / Felder
        public DirectoryInfo? PathName { get; init; }
        public FileInfo? ConfigPathFile { get; init; }
        #endregion

        #region Konstruktor
        public ModHandler(string aModDirectoryName, string aModSortJsonName)
            : this(Assembly.GetCallingAssembly(), aModDirectoryName, aModSortJsonName) { }

        public ModHandler(Assembly aAssembly, string aModDirectoryName, string aModSortJsonName) {
            bool lProceed = true;

            if (string.IsNullOrWhiteSpace(aModDirectoryName)) {
                lProceed = false;
                ExceptionHandler.Add(new Exception.MissingParameterException(nameof(aModDirectoryName)));
            }
            if (string.IsNullOrWhiteSpace(aModSortJsonName)) {
                lProceed = false;
                ExceptionHandler.Add(new Exception.MissingParameterException(nameof(aModSortJsonName)));
            }

            if (lProceed) {
                PathName = Filesystem.DirectoryHandler.GetDirectory(aAssembly, aModDirectoryName);

                if (PathName.Exists) {
                    ConfigPathFile = new FileInfo(Path.Combine(PathName.FullName, aModSortJsonName));

                    if (!ConfigPathFile.Exists) {
                        int lCounter = 0;
                        List<ModSortData> lList = new();

                        foreach (FileInfo lFile in GetDllListFromFS()) {
                            lList.Add(new() {
                                Filename = lFile.Name,
                                SortWeight = lCounter++,
                                IsActive = false
                            });
                        }

                        File.WriteAllText(ConfigPathFile.FullName, JsonSerializer.Serialize(lList));
                    }
                    //Laden
                } else {
                    ExceptionHandler.Add(new Exception.Filesystem.MissingDirectoryOrFileException(PathName));
                }
            }
        }
        #endregion

        #region Methoden
        private List<FileInfo> GetDllListFromFS() {
            List<FileInfo> lResult = new();
            string[] lFiles = Directory.GetFiles(PathName.FullName, "*.dll", SearchOption.AllDirectories);

            if (lFiles != null) {
                lFiles.ToList().ForEach(x => lResult.Add(new FileInfo(x)));
            }

            return lResult;
        }








        /*
        public List<ModData> GetModList() {
            FileInfo lPathFile = new(Path.Combine(PathName.FullName, "ModSort.json"));

            if (lPathFile.Exists) {
                using (StreamReader lReader = new("ModSort.json")) {
                    string json = lReader.ReadToEnd();
                    List<Item> items = JsonConvert.DeserializeObject<List<Item>>(json);
                }

                ModSortData? weatherForecast =
                JsonSerializer.Deserialize<ModSortData>(jsonString);
            }
        }
        
        public List<ModData> GetModList(bool aIsActive) {
            List<ModData> lResult = new();
            string[] lFiles = Directory.GetFiles(PathName.FullName, "*.dll", SearchOption.AllDirectories);

            if (lFiles != null) {
                lFiles.ToList().ForEach(x => lResult.Add(new ModData(x, aIsActive)));
            }

            return lResult;
        }
*/


        public void LoadMods(List<ModData> aModList, Type aInterface) {
            foreach (ModData lMod in aModList.Where(x => x.IsActive)) {
                lMod.Instance = LoadMod(lMod.PathFile, aInterface);
            }
        }

        public dynamic? LoadMod(FileInfo aPathFile, Type aInterface) {
            try {
                aPathFile.Refresh();

                if (aPathFile.Exists) {
                    List<Type> lTypes = Assembly.Load(File.ReadAllBytes(aPathFile.FullName)).GetTypes()
                        .Where(x => x.IsClass && !x.IsAbstract)
                        .Where(aInterface.IsAssignableFrom).ToList() ?? new();

                    if (lTypes.Count > 0) {
                        return Activator.CreateInstance(lTypes.First());
                    }
                }

            } catch (System.Exception aEx) {
                ExceptionHandler.Add(aEx);
            }

            return null;
        }
        #endregion

        private class ModSortData {
            public string Filename { get; set; } = string.Empty;
            public int SortWeight { get; set; } = 0;
            public bool IsActive { get; set; } = false;

        }
    }
}