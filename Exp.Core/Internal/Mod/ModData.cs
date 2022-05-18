using System.Reflection;
using System.Text;

namespace Exp.Internal.Mod {
    public class ModData {
        #region Properties / Felder
        public FileInfo PathFile { get; init; }
        public dynamic? Instance { get; init; }
        public string Name { get; init; }
        public string Version { get; init; }
        public string Description { get; init; }
        public int SortWeight { get; set; }
        public bool IsActive { get; set; }
        public bool IsLoaded { get; private set; }
        #endregion

        #region Konstruktor
        internal ModData(FileInfo aPathFile, dynamic? aInstance) {
            PathFile = aPathFile;
            Instance = aInstance;
            Name = Path.GetFileNameWithoutExtension(PathFile.Name);

            if (Instance == null) {
                IsLoaded = false;
                Version = string.Empty;
                Description = string.Empty;
            } else {
                IEnumerable<CustomAttributeData> lAttributes = Instance.GetType().Assembly.CustomAttributes;

                IsLoaded = true;
                Version = GetAttribute(lAttributes, "AssemblyInformationalVersionAttribute");
                Description = GetAttribute(lAttributes, "AssemblyDescriptionAttribute");
            }
        }
        #endregion

        #region Methoden
        public string GetFullDescription() {
            string lResult = $"{nameof(Name)}: {Name}{Environment.NewLine}";

            lResult += $"{nameof(Version)}: {Version}{Environment.NewLine}";
            lResult += $"{Environment.NewLine}{Description}";

            return lResult;
        }

        internal void Initialize() {
            if (Instance != null) {
                Instance.Initialize();
            }
        }

        private static string GetAttribute(IEnumerable<CustomAttributeData> aData, string aName) {
            CustomAttributeData? lAttribute = aData
                .Where(x => x.AttributeType.Name.Equals(aName, StringComparison.InvariantCultureIgnoreCase))
                .FirstOrDefault();

            if (lAttribute == null) {
                return string.Empty;
            } else {
                StringBuilder lResult = new();

                foreach (var lArgument in lAttribute.ConstructorArguments) {
                    lResult.Append(lArgument.Value);
                }

                return lResult.ToString();
            }
        }
        #endregion
    }
}