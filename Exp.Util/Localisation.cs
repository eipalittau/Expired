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

        private static void AddResourceFile(string aResourceName, Assembly aAssembly) {
            ResourceData? lItem = GetItem(aAssembly);

            if (lItem == null) {
                ResourceList.Add(new ResourceData(aAssembly, aResourceName, Language));
            } else {
                lItem.LoadedLanguage = Language;
            }
        }
        #endregion

        #region GetText
        public static string GetText(string aID) {
            return GetText(aID, Assembly.GetCallingAssembly());
        }

        public static string GetText(string aID, params string[] aArguments) {
            string lText = GetText(aID);

            if (aArguments.HasData()) {
                return string.Format(lText, aArguments);
            } else {
                return lText;
            }
        }

        public static string GetText(string aID, Assembly aAssembly) {
            ResourceData? lItem = GetItem(aAssembly);

            if (lItem == null) {
                ExceptionHandler.Add(new Exception.ResourceNotFoundException(aID, aAssembly));

                return string.Empty;
            } else {
                return lItem.GetText(Language, aID);
            }
        }

        public static string GetText(string aID, Assembly aAssembly, params string[] aArguments) {
            string lText = GetText(aID, aAssembly);

            if (aArguments.HasData()) {
                return GetTextFormatted(lText, aArguments);
            } else {
                return lText;
            }
        }

        private static string GetTextFormatted(string aText, params string[] aArguments) {
            if (aText.Equals(string.Empty)) {
                return aText;
            }

            return string.Format(aText, aArguments);
        }
        #endregion

        private static ResourceData? GetItem(Assembly aAssembly) {
            return ResourceList
                .Where(x => x.Caller.IsEqual(aAssembly))
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