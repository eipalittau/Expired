﻿namespace RtD.Data.Json { // Json/Loader/Base
    internal class LoaderBase<T> where T : JsonDataBase {
        #region Properties / Felder
        protected Main Parent { get; private set; }
        protected Enumerations.LanguageEnum Language { get; private set; }
        private readonly Components.Filesystem.JsonHandler<JsonData<T>> _JsonHandlerData = new();
        protected List<T> JsonData {
            private set {
                if (_JsonHandlerData.Json != null) {
                    _JsonHandlerData.Json.DataList = value; 
                }
            }
            get {
                if (_JsonHandlerData.Json == null) {
                    return new List<T>();
                }

                return _JsonHandlerData.Json.DataList;
            }
        }
        protected string FileNameData {
            get {
                return LoaderBase<T>.GetFilename(_JsonHandlerData.PathFile);
            }
        }
        #endregion

        #region Konstruktor
        protected LoaderBase(Main aParent, Enumerations.LanguageEnum aLanguage)
            => (Parent, Language) = (aParent, aLanguage);
        #endregion

        #region Methoden
        protected void LoadData(string aPathName, int aID) {
            List<LanguageJsonData>? lJsonLanguage = null;

            _JsonHandlerData.LoadJson(new FileInfo(Path.Combine(aPathName, Constants.GetJsonFileName(aID))));

            if (_JsonHandlerData.Json == null) {
                throw new Exceptions.MissingDataException();
            }

            try {
                Components.Filesystem.JsonHandler<JsonLanguageData> lJsonHandlerLanguage = new();

                lJsonHandlerLanguage.LoadJson(new FileInfo(Path.Combine(aPathName, Constants.GetJsonFileName(aID, Language))));

                if (lJsonHandlerLanguage.Json != null) {
                    lJsonLanguage = lJsonHandlerLanguage.Json.DataList;
                }
            } catch (System.Exception aEx) {
                Main.AddWarning(aEx);
            }

            if (lJsonLanguage != null) {
                foreach (T lDataItem in JsonData) {
                    LanguageJsonData? lLanguageItem = lJsonLanguage.Where(x => x.ID == lDataItem.ID).FirstOrDefault();

                    if (lLanguageItem != null) {
                        lLanguageItem.Name = lDataItem.Name;
                        lLanguageItem.Description = lDataItem.Description;
                    }
                }
            }
        }

        protected bool Except(IEnumerable<T>? aData) {
            if (aData != null && aData.Any()) {
                JsonData = JsonData.Except(aData).ToList();
                return true;
            } else {
                return false;
            }
        }

        protected void RemoveEmpty() {
            IEnumerable<T> lEmptyList = JsonData.Where(x => string.IsNullOrWhiteSpace(x.Name));

            if (lEmptyList.Any()) {
                Main.AddWarning(0000, nameof(JsonDataBase.Name));

                JsonData = JsonData.Except(lEmptyList).ToList();
            }
        }

        protected void Check4Dublicates() {
            IEnumerable<T>? lDouble;

            if (!JsonData.Any()) {
                throw new Exceptions.MissingDataException();
            }

            lDouble = JsonData.GroupBy(x => x.ID).Where(g => g.Skip(1).Any()).SelectMany(x => x);
            if (lDouble.Any()) {
                throw new Exceptions.DublicateDataException(nameof(JsonDataBase.ID), lDouble.First().ID);
            }

            lDouble = JsonData.GroupBy(x => x.Name).Where(g => g.Skip(1).Any()).SelectMany(x => x);
            if (lDouble.Any()) {
                throw new Exceptions.DublicateDataException(nameof(JsonDataBase.Name), lDouble.First().ID);
            }
        }

        private static string GetFilename(FileInfo? aValue) {
            return aValue == null ? string.Empty : aValue.Name;
        }
        #endregion

    }

    public class JsonData<T> {
        public List<T> DataList { get; set; } = new();
    }

    public class JsonLanguageData {
        public List<LanguageJsonData> DataList { get; set; } = new();
    }
}