using System.Globalization;
using System.Resources;

namespace RtD.Components {
    internal static class Localisation {
        #region Properties / Felder
        internal static Enumerations.LanguageEnum Language  {
            get  {
                return _Language;
            }
            set {
                if (_Language != value || mResourceSets.Count == 0) {
                    try {
                        //mResourceSet = Base.Message.Messages.ResourceManager.GetResourceSet(new CultureInfo(value.ToString()), true, true);

                        _Language = value;
                    } catch {
                        //mResourceSets = null;
                    }
                }
            }
        }

        private static Enumerations.LanguageEnum _Language = Enumerations.LanguageEnum.None;
        private static readonly List<ResourceSet> mResourceSets = new();
        #endregion

        #region Methoden
        internal static void AddResource(System.Reflection.Assembly aResource) {
            //mResourceSets.Add(aResource.GetResourceSet());
        }

        internal static string GetMessageText(long aID) {
            // $"MSG_{aID:D5}";
            return string.Empty;
        }

        internal static string GetMessageText(long aID, params string[] aArguments) {
            // $"MSG_{aID:D5}";
            return string.Empty;
        }

        internal static string Translate(string aID, string aValue) {

        }
        #endregion
    }
}
