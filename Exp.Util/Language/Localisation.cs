using Exp.Util.Enumeration;
using Exp.Util.Extension;
using System.Reflection;
using System.Resources;

namespace Exp.Util
{
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
            if (!GetItem(aAssembly).Any()) {
                ResourceList.Add(new ResourceData(aAssembly, aResourceName));
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
            IEnumerable<ResourceData> lItem = GetItem(aAssembly);

            if (lItem.Any()) {
                return lItem.First().GetText(Language, aID);
            } else {
                ExceptionHandler.Add(new Exception.ResourceNotFoundException(aID, aAssembly));

                return string.Empty;
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

        private static IEnumerable<ResourceData> GetItem(Assembly aAssembly) {
            return ResourceList.Where(x => x.Caller.IsEqual(aAssembly));
        }
        #endregion

        private class ResourceData {
            #region Properties / Felder
            internal Assembly Caller { get; }
            private ResourceManager Manager { get; init; }
            private ResourceSet? ResourceSet { get; set; }

            private LanguageEnum? mLoadedLanguage;
            #endregion

            #region Konstruktor
            internal ResourceData(Assembly aCaller, string aResourceName) {
                Caller = aCaller;
                Manager = new ResourceManager(aCaller.TryGetName(aSuffix: $".{aResourceName}"), aCaller);
            }
            #endregion

            #region Methoden
            internal string GetText(LanguageEnum aLanguage, string aName) {
                if (mLoadedLanguage != aLanguage || ResourceSet == null) {
                    ResourceSet = Manager.GetResourceSet(aLanguage.CI, true, true);
                    mLoadedLanguage = aLanguage;
                }

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