using System.Text.Json;

namespace Exp.Util.Filesystem {
    public class JsonBase<T> where T : new() {
        #region Properties / Felder
        protected FileInfo PathFile { get; init; }
        protected T Json { get; init; }
        #endregion

        #region Konstruktor
        protected JsonBase(FileInfo aPathFile, bool aThrowExecptionOnFail) {
            T? lJson = default;

            PathFile = aPathFile;
            PathFile.Refresh();

            if (PathFile.Exists) {
                try {
                    lJson = JsonSerializer.Deserialize<T>(File.ReadAllText(PathFile.FullName));
                } catch (System.Exception aEx) {
                    ExceptionHandler.Add(new Exception.Filesystem.WrongJsonFormatException(aEx, PathFile), aThrowExecptionOnFail);
                }
            }

            Json = lJson is null ? new T() : lJson;
        }
        #endregion

        #region Methoden
        protected void Save() {
            File.WriteAllText(PathFile.FullName, JsonSerializer.Serialize(Json));
        }
        #endregion
    }
}