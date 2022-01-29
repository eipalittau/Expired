namespace RtD.Data.Json {
    internal class LoaderBase<T> {
        #region Properties / Felder
        protected Main Parent { get; private set; }
        protected Enumerations.LanguageEnum Language { get; private set; }
        private readonly Components.Filesystem.JsonHandler<T> _Json = new();
        protected T? Json {
            get {
                return _Json.Json;
            }
        }
        protected Components.Filesystem.JsonHandler<JsonLanguageData> JsonLanguage { get; } = new Components.Filesystem.JsonHandler<JsonLanguageData>();
        protected string FileNameData {
            get {
                return LoaderBase<T>.GetFilename(_Json.PathFile);
            }
        }
        protected string FileNameLanguage {
            get {
                return LoaderBase<T>.GetFilename(JsonLanguage.PathFile);
            }
        }
        #endregion

        #region Konstruktor
        protected LoaderBase(Main aParent, Enumerations.LanguageEnum aLanguage)
            => (Parent, Language) = (aParent, aLanguage);            
        #endregion

        #region Methoden
        protected void LoadData(string aPathName, string aFileName) {
            _Json.LoadJson(new FileInfo(Path.Combine(aPathName, aFileName)));
        }

        protected void LoadLanguage(string aPathName, string aFileName) {
            JsonLanguage.LoadJson(new FileInfo(Path.Combine(aPathName, aFileName)));
        }
        
        protected IEnumerable<TT> RemoveEmpty<TT>(IEnumerable<TT> aData) where TT : JsonDataBase {
            if (aData.Where(x => string.IsNullOrWhiteSpace(x.Name)).Any()) {
                Main.AddWarning(0000, nameof(JsonDataBase.Name));

                return aData.Where(x => !string.IsNullOrWhiteSpace(x.Name));
            } else {
                return aData;
            }
        }

        protected void Check4Dublicates<TT>(IEnumerable<TT> aData) where TT : JsonDataBase {
            if (!aData.Any()) {
                throw new Exceptions.MissingDataException();
            }

            if (aData
                .GroupBy(x => x.ID)
                .Where(g => g.Skip(1).Any())
                .SelectMany(x => x)
                .Any()) {
                throw new Exceptions.DublicateDataException(nameof(JsonDataBase.ID));
            }

            if (aData
                .GroupBy(x => x.Name)
                .Where(g => g.Skip(1).Any())
                .SelectMany(x => x)
                .Any()) {
                throw new Exceptions.DublicateDataException(nameof(JsonDataBase.Name));
            }
        }

        private static string GetFilename(FileInfo? aValue) {
            return aValue == null ? string.Empty : aValue.Name;
        }
        #endregion

    }

    public class JsonLanguageData {
        //public List<EnemyClassJsonData> Data { get; } = new();
    }
}