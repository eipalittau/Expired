namespace RtD.Data {
    public sealed class Main : Components.MessageBase {
        public Main() { }

        public GameData LoadData(string aPathName, Enumerations.LanguageEnum aLanguage) {
            GameData lData = new();

            lData.EnemyClasses = StartLoader(new Json.EnemyClassesLoader(this, aLanguage), aPathName);
            lData.ItemQualities = StartLoader(new Json.ItemQualitiesLoader(this, aLanguage), aPathName);
            lData.Items = StartLoader(new Json.ItemsLoader(this, aLanguage), aPathName);
            lData.Loots = StartLoader(new Json.LootsLoader(this, aLanguage), aPathName);

            return lData;
        }

        private List<EnemyClassData> StartLoader(Json.EnemyClassesLoader aLoader, string aPathName) {
            base.RaiseMessage(aLoader.LoadData(aPathName));

            return aLoader.Data;
        }

        private List<ItemQualityData> StartLoader(Json.ItemQualitiesLoader aLoader, string aPathName) {
            base.RaiseMessage(aLoader.LoadData(aPathName));

            return aLoader.Data;
        }

        private List<ItemData> StartLoader(Json.ItemsLoader aLoader, string aPathName) {
            base.RaiseMessage(aLoader.LoadData(aPathName));

            return aLoader.Data;
        }

        private List<LootData> StartLoader(Json.LootsLoader aLoader, string aPathName) {
            base.RaiseMessage(aLoader.LoadData(aPathName));

            return aLoader.Data;
        }
    }
}