namespace RtD.Data.Json {
    internal sealed class EnemyClassesLoader : LoaderBase<EnemyClassesLoader.JsonData> {
        #region Properties / Felder
        public List<EnemyClassData> Data { get; } = new List<EnemyClassData>();
        #endregion

        #region Konstruktor
        public EnemyClassesLoader(Main aParent) : base(aParent) { }
        #endregion

        #region Methoden
        public Components.Notification[] LoadData(string aPathName) {
            base.LoadData(aPathName, "EnemyClasses.json");

            if (base.Json == null) {
                throw new Exceptions.MissingDataException();
            } else {
                IEnumerable<EnemyClassJsonData> lData = base.RemoveEmpty(base.Json.Data);
                uint lSortOrder = 0;

                base.Check4Dublicates(lData);

                foreach (EnemyClassJsonData lJsonData in lData
                    .OrderBy(x => x.Name)) {
                    Data.Add(new EnemyClassData(lJsonData, lSortOrder++));
                }
            }

            return base.GetNotifications();
        }
        #endregion

        #region Verschachtete Klassen
        public class JsonData {
            public List<EnemyClassJsonData> Data { get; } = new();
        }
        #endregion
    }
}