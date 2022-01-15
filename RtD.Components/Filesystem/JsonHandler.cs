using Newtonsoft.Json;
using System.Text;

namespace RtD.Components.Filesystem {
    public class JsonHandler<T> {
        #region Properties / Felder
        internal T? Json { get; private set; } = default;
        internal bool IsLoaded {
            get {
                return Json != null;
            }
        }
        internal FileInfo? PathFile { get; private set; }
        #endregion

        #region Konstruktor
        internal JsonHandler() { }
        #endregion

        #region Methoden
        #region LoadJson
        internal void LoadJson(FileInfo aPathFile) {
            LoadJson(aPathFile, false);
        }

        internal void LoadJson(FileInfo aPathFile, bool aReload) {
            if (aPathFile.Exists) {
                PathFile = aPathFile;

                using (StreamReader lStreamReader = new(aPathFile.FullName)) {
                    LoadJson(lStreamReader.ReadToEnd(), aReload);
                    lStreamReader.Close();
                    lStreamReader.Dispose();
                }
            } else {
                throw new Exceptions.Filesystem.MissingFileException(aPathFile);
            }
        }

        internal void LoadJson(byte[] aJson) {
            LoadJson(aJson, false);
        }

        internal void LoadJson(byte[] aJson, bool aReload) {
            LoadJson(Encoding.Default.GetString(aJson), aReload);
        }

        internal void LoadJson(string aJson) {
            LoadJson(aJson, false);
        }

        internal void LoadJson(string aJson, bool aReload) {
            try {
                if (Json == null || aReload) {
                    Json = JsonConvert.DeserializeObject<T>(aJson);
                }

            } catch (System.Exception aEx) {
                throw new Exceptions.Json.WrongJsonFormatException(aEx, GetArgument());
            }
        }
        #endregion

        private static string GetArgument() {
            Type? lDeclaringType = typeof(T).DeclaringType;

            return lDeclaringType == null ? typeof(T).Name : lDeclaringType.Name;
        }
        #endregion
    }
}