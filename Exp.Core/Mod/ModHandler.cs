﻿using System.Reflection;

namespace Exp.Core.Mod {
    public class ModHandler {
        #region Properties / Felder
        public static ModHandler Singleton { get; } = new("MODS", "ModSort.json", "Exp.DefaultMod");
        public DirectoryInfo ModPath { get; init; }
        public FileInfo ConfigPathFile { get; init; }
        private List<ModData> ModData { get; } = new();
        private JsonModSortHandler JsonMods { get; init; }
        private bool Proceed { get; init; }
        private string DefaultMod { get; init; }
        #endregion

        #region Konstruktor
        private ModHandler(string aModDirectoryName, string aModSortJsonName, string aDefaultMod) {
            if (string.IsNullOrWhiteSpace(aModDirectoryName)) {
                Proceed = false;
                Util.ExceptionHandler.Add(new Exception.MissingParameterException(nameof(aModDirectoryName)));
            }
            if (string.IsNullOrWhiteSpace(aModSortJsonName)) {
                Proceed = false;
                Util.ExceptionHandler.Add(new Exception.MissingParameterException(nameof(aModSortJsonName)));
            }
            if (string.IsNullOrWhiteSpace(aDefaultMod)) {
                Proceed = false;
                Util.ExceptionHandler.Add(new Exception.MissingParameterException(nameof(aDefaultMod)));
            }

            DefaultMod = aDefaultMod;
            ModPath = Util.Filesystem.DirectoryHandler.GetDirectory(Assembly.GetCallingAssembly(), aModDirectoryName);
            ConfigPathFile = new FileInfo(Path.Combine(ModPath.FullName, aModSortJsonName));
            JsonMods = new(ConfigPathFile);

            if (ModPath.Exists) {
                Proceed = true;
            } else {
                Util.ExceptionHandler.Add(new Exception.Filesystem.MissingDirectoryException(ModPath));
            }
        }
        #endregion

        #region Methoden
        public void LoadList(Type aInterface) {
            int lCounter = 0;

            if (!Proceed) {
                Util.ExceptionHandler.Add(new Exception.Filesystem.MissingDirectoryException(ModPath));
                return;
            }

            if (JsonMods.Json.Count > 0) {
                lCounter = Math.Max(0, JsonMods.Json.Max(x => x.SortWeight));
            }

            foreach (FileInfo lFile in GetDllListFromFS()) {
                try {
                    List<Type> lTypes = LoadAssembly(lFile.FullName, aInterface);

                    if (lTypes.Count > 0) {
                        JsonModSortData? lJsonItem = JsonMods.Json
                            .Where(x => x.Filename.Equals(lFile.Name, StringComparison.InvariantCultureIgnoreCase))
                            .FirstOrDefault();
                        ModData lModItem = new(lFile, Activator.CreateInstance(lTypes.First()));

                        if (lModItem.IsLoaded) {
                            if (lModItem.Name.Equals(DefaultMod, StringComparison.InvariantCultureIgnoreCase)) {
                                lModItem.SortWeight = int.MinValue;
                            } else {
                                if (lJsonItem != null) {
                                    lModItem.SortWeight = lJsonItem.SortWeight;
                                } else {
                                    lModItem.SortWeight = ++lCounter;
                                }
                            }

                            if (lJsonItem == null) {
                                lModItem.IsActive = false;
                            } else {
                                lModItem.IsActive = lJsonItem.IsActive;
                            }

                            ModData.Add(lModItem);
                        }
                    }

                } catch (System.Exception aEx) {
                    Util.ExceptionHandler.Add(aEx);
                }
            }
        }

        #region Get
        public List<ModData> GetList(bool aOnlyActive) {
            IEnumerable<ModData> lList = ModData.OrderBy(x => x.SortWeight);

            if (aOnlyActive) {
                lList = lList.Where(x => x.IsActive);
            }

            return lList.ToList();
        }

        public List<ModData> GetList() {
            return GetList(false);
        }

        public ModData GetItem(string aName) {
            return ModData
                .Where(x => x.Name.Equals(aName, StringComparison.InvariantCultureIgnoreCase))
                .First();
        }
        #endregion

        public void Save() {
            if (ConfigPathFile.Exists) {
                ConfigPathFile.Delete();
            }
            JsonMods.Json.Clear();

            foreach (ModData aData in ModData) {
                JsonMods.Json.Add(new() {
                    Filename = aData.PathFile.Name,
                    SortWeight = aData.SortWeight,
                    IsActive = aData.IsActive
                });
            }
            JsonMods.Save();
        }

        public void InitializeActiveMods() {
            GetList(true).ForEach(x => x.Initialize());
        }

        public void InitializeActiveMods(Type aInterface) {
            LoadList(aInterface);
            InitializeActiveMods();
        }

        private List<Type> LoadAssembly(string aPathFileName, Type aInterface) {
            return Assembly.Load(File.ReadAllBytes(aPathFileName)).GetTypes()
                .Where(x => x.IsClass && !x.IsAbstract)
                .Where(aInterface.IsAssignableFrom).ToList() ?? new();
        }

        private List<FileInfo> GetDllListFromFS() {
            List<FileInfo> lResult = new();

            string[] lFiles = Directory.GetFiles(ModPath.FullName, "*.dll", SearchOption.AllDirectories);

            if (lFiles != null) {
                lFiles.ToList().ForEach(x => lResult.Add(new FileInfo(x)));
            }

            return lResult;
        }
        #endregion
    }
}