using Newtonsoft.Json;
using System.Text;

namespace RtD.Components.Filesystem {
    public class JsonHandler<T> {
        #region Properties / Felder
        public T? Json { get; private set; } = default;
        public bool IsLoaded {
            get {
                return Json != null;
            }
        }
        public FileInfo? PathFile { get; private set; }
        #endregion

        #region Konstruktor
        public JsonHandler() { }
        #endregion

        #region Methoden
        #region LoadJson
        public void LoadJson(FileInfo aPathFile) {
            LoadJson(aPathFile, false);
        }

        public void LoadJson(FileInfo aPathFile, bool aReload) {
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

        public void LoadJson(byte[] aJson) {
            LoadJson(aJson, false);
        }

        public void LoadJson(byte[] aJson, bool aReload) {
            LoadJson(Encoding.Default.GetString(aJson), aReload);
        }

        public void LoadJson(string aJson) {
            LoadJson(aJson, false);
        }

        public void LoadJson(string aJson, bool aReload) {
            try {
                if (Json == null || aReload) {
                    Json = JsonConvert.DeserializeObject<T>(aJson);
                }

            } catch (System.Exception aEx) {
                throw new Exceptions.Json.WrongJsonFormatException(aEx, GetArgument<T>());
            }
        }
        #endregion

        private static string GetArgument<T>() {
            Type? lDeclaringType = typeof(T).DeclaringType;

            return lDeclaringType == null ? typeof(T).Name : lDeclaringType.Name;
        }
        #endregion
    }
}