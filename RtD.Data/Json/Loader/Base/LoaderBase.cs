namespace RtD.Data.Json {
    //Patrik: Json als Property, nicht als Vererbung.
    internal class LoaderBase<T> : Components.Filesystem.JsonBase<T> {
        #region Properties / Felder
        protected Main Parent { get; private set; }
        protected Enumerations.LanguageEnum Language { get; private set; }
        protected  string FileName {
            get {
                return base.PathFile == null ? string.Empty : base.PathFile.Name;
            }
        }
        #endregion

        #region Konstruktor
        protected LoaderBase(Main aParent, Enumerations.LanguageEnum aLanguage)
            : base()
            => (Parent, Language) = (aParent, aLanguage);
        #endregion

        #region Methoden
        protected void LoadData(string aPathName, string aFileName) {
            base.LoadJson(new FileInfo(Path.Combine(aPathName, aFileName)));
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
        #endregion
    }
}