using Exp.Util.Extension;
using System.Globalization;
using System.Reflection;
using System.Resources;

namespace Exp.Util {
    public static class Localisation {
        #region Properties / Felder
        public static LanguageEnum Language { get; set; } = LanguageEnum.None;
        private static List<ResourceData> ResourceList { get; } = new();
        #endregion

        #region Methoden
        public static void AddResourceFile(string aResourceName) {
            Assembly lAssembly = Assembly.GetCallingAssembly();
            ResourceData? lItem = GetItem(lAssembly);

            if (lItem == null) {
                ResourceList.Add(new ResourceData(lAssembly, aResourceName, Language));
            } else {
                lItem.LoadedLanguage = Language;
            }
        }

        public static string GetText(string aName) {
            return GetText(aName, Assembly.GetCallingAssembly());
        }

        public static string GetText(string aName, Assembly aAssembly) {
            ResourceData? lItem = GetItem(aAssembly);

            if (lItem == null) {
                ExceptionHandler.Add(new Exception.ResourceNotFoundException(aName, aAssembly));
                return string.Empty;
            } else {
                return lItem.GetText(Language, aName);
            }
        }

        private static ResourceData? GetItem(Assembly aAssembly) {
            return ResourceList
                .Where(x => x.Caller.TryGetName().Equals(aAssembly.TryGetName(), StringComparison.CurrentCultureIgnoreCase))
                .FirstOrDefault();
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
                string lBaseName = aResourceName;
                AssemblyName? lAssemblyName = aCaller.GetName();

                if (lAssemblyName != null && !string.IsNullOrWhiteSpace(lAssemblyName.Name)) {
                    lBaseName = string.Concat(lAssemblyName.Name, ".", aResourceName);
                }
                
                ResMan = new ResourceManager(lBaseName, aCaller);
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