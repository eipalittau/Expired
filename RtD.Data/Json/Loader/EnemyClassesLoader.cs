namespace RtD.Data.Json {
    internal sealed class EnemyClassesLoader : LoaderBase<EnemyClassesLoader.JsonData> {
        #region Properties / Felder
        #endregion

        #region Konstruktor
        public EnemyClassesLoader(Main aParent, Enumerations.LanguageEnum aLanguage)
            : base(aParent, aLanguage) { }
        #endregion

        #region Methoden
        public List<EnemyClassData> LoadData(string aPathName) {
            List<EnemyClassData> lResult = new();

            base.LoadData(aPathName, Constants.GetJsonFileName(0));

            if (base.Json == null) {
                throw new Exceptions.MissingDataException();
            } else {
                IEnumerable<EnemyClassJsonData> lData = base.RemoveEmpty(base.Json.Data);
                uint lSortOrder = 0;

                base.Check4Dublicates(lData);

                foreach (EnemyClassJsonData lJsonData in lData
                    .OrderBy(x => x.Name)) {
                    lResult.Add(new EnemyClassData(lJsonData, lSortOrder++));
                }
            }

            // TODO: Sprache laden
            base.LoadData(aPathName, Constants.GetJsonFileName(0, base.Language));

            return lResult;
        }
        #endregion

        #region Verschachtete Klassen
        public class JsonData {
            public List<EnemyClassJsonData> Data { get; } = new();
        }
        #endregion
    }
}