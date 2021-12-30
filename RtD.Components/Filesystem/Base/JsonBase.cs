using Newtonsoft.Json;
using System.Text;

namespace RtD.Components.Filesystem {
    public abstract class JsonBase<T> {
        #region Properties / Felder
        protected T? Json { get; private set; } = default;
        protected bool IsLoaded { 
            get {
                return Json != null;
            } 
        }
        #endregion

        #region Konstruktor
        protected JsonBase() { }
        #endregion

        #region Methoden
        #region LoadJson
        protected void LoadJson(FileInfo aPathFile) {
            LoadJson(aPathFile, false);
        }

        protected void LoadJson(FileInfo aPathFile, bool aReload) {
            if (aPathFile.Exists) {
                using (StreamReader lStreamReader = new(aPathFile.FullName)) {
                    LoadJson(lStreamReader.ReadToEnd());
                    lStreamReader.Close();
                    lStreamReader.Dispose();
                }
            } else {
                throw new Exceptions.Filesystem.MissingFileException(aPathFile);
            }
        }

        protected void LoadJson(byte[] aJson) {
            LoadJson(aJson, false);
        }

        protected void LoadJson(byte[] aJson, bool aReload) {
            LoadJson(Encoding.Default.GetString(aJson), aReload);
        }

        protected void LoadJson(string aJson) {
            LoadJson(aJson, false);
        }

        protected void LoadJson(string aJson, bool aReload) {
            try {
                if (Json == null || aReload) {
                    Json = JsonConvert.DeserializeObject<T>(aJson);
                }

            } catch (System.Exception aEx) {
                throw new Exceptions.Json.WrongJsonFormatException(aEx, GetArgument());
            }
        }
        #endregion

        private string GetArgument() {
            Type? lDeclaringType = typeof(T).DeclaringType;

            return lDeclaringType == null ? typeof(T).Name : lDeclaringType.Name;
        }
        #endregion
    }
}