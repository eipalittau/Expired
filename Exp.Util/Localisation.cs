using Exp.Util.Extension;
using System.Globalization;
using System.Reflection;
using System.Resources;

namespace Exp.Util {
    public static class Localisation {
        #region Properties / Felder
        public static LanguageEnum Language { get; set; } = LanguageEnum.None;
        private static List<ResourceData> ResourceList { get; } = new();
        private static bool AddLocalResource { get; set; } = true;
        #endregion

        #region Methoden
        #region Add
        public static void AddResourceFile(string aResourceName) {
            if (AddLocalResource) {
                AddResourceFile("Labeling.Labeling", Assembly.GetExecutingAssembly());
                AddLocalResource = false;
            }
            AddResourceFile(aResourceName, Assembly.GetCallingAssembly());
        }
        #endregion

        public static string GetText(string aName) {
            return GetText(aName, Assembly.GetCallingAssembly());
        }

        public static string GetText(string aName, Assembly aAssembly) {
            ResourceData? lItem = GetItem(aAssembly);

            if (lItem == null) {
                throw new Exception.ResourceNotFoundException(aName, aAssembly);
            } else {
                return lItem.GetText(Language, aName);
            }
        }

        private static ResourceData? GetItem(Assembly aAssembly) {
            return ResourceList
                .Where(x => x.Caller.TryGetName().Equals(aAssembly.TryGetName(), StringComparison.CurrentCultureIgnoreCase))
                .FirstOrDefault();
        }

        private static void AddResourceFile(string aResourceName, Assembly aAssembly) {
            ResourceData? lItem = GetItem(aAssembly);

            if (lItem == null) {
                ResourceList.Add(new ResourceData(aAssembly, aResourceName, Language));
            } else {
                lItem.LoadedLanguage = Language;
            }
        }

        #endregion

        private class ResourceData {
            #region Properties / Felder
            internal Assembly Caller { get; }
            private LanguageEnum _LoadedLanguage = LanguageEnum.None;
            internal LanguageEnum LoadedLanguage {
                get {
                    return _LoadedLanguage;
                }
                set {
                    if (value != LanguageEnum.None) {
                        if (_LoadedLanguage != value || ResourceSet == null) {
                            _LoadedLanguage = value;
                            ResourceSet = ResMan.GetResourceSet(new CultureInfo(value.ISO), true, true);
                        }
                    }
                }
            }
            private ResourceManager ResMan { get; init; }
            private ResourceSet? ResourceSet { get; set; }
            #endregion

            #region Konstruktor
            internal ResourceData(Assembly aCaller, string aResourceName, LanguageEnum aLanguage) {
                ResMan = new ResourceManager(aCaller.TryGetName(aSuffix: $".{aResourceName}"), aCaller);
                Caller = aCaller;
                LoadedLanguage = aLanguage;
            }
            #endregion

            #region Methoden
            internal string GetText(LanguageEnum aLanguage, string aName) {
                LoadedLanguage = aLanguage;

                if (ResourceSet == null) {
                    return string.Empty;
                } else {
                    return ResourceSet.GetString(aName, true) ?? string.Empty;
                }
            }
            #endregion
        }

    }
}